using OctoprintScanner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OctoprintScanner
{
    public partial class OctoprintScanner : Form
    {
        private Task[] taskArray;
        private CancellationTokenSource CancellationTokenStore;
        private CancellationToken ct;
        private IpRanger _ranger { get; set; }
        private List<Endpoint> _toScan;
        private List<Endpoint> _scanned;
        private List<Endpoint> _matched;
        private bool _needClearPlaceholder = false;

        public OctoprintScanner()
        {
            InitializeComponent();
            UpdateList();
        }

        private void ExtThreadUpdateUI(Endpoint item)
        {
            this.UpdateUI(item);
        }

        private void UpdateUI(Endpoint item)
        {
            if (this.lstMatches.InvokeRequired)
            {
                Delegates.PropertyChangedEventHandler d = new Delegates.PropertyChangedEventHandler(UpdateUI);
                this.Invoke(d, new object[] { item });
            } else
            {
                if(item != null)
                {
                    if (item.Matched)
                    {
                        if (_needClearPlaceholder)
                        {
                            lstMatches.Items.Clear();
                            _needClearPlaceholder = false;
                        }

                        _matched.Add(item);
                        string[] row = { item.BaseAddress };
                        var listItem = new ListViewItem(row);
                        lstMatches.Items.Add(listItem);
                    }
                    else
                    {
                        _scanned.Add(item);
                    }
                    _toScan.Remove(item);
                }
                
                lblCountToScanValue.Text = _toScan.Count.ToString();
                lblCntScanned.Text = _scanned.Count.ToString();
                lblCountIdent.Text = _matched.Count.ToString();

                if (_toScan.Count == 0) btnReset.Enabled = true;
                if (_toScan.Count > 0 && _scanned.Count == 0) btnStartScan.Enabled = true;
            }
        }

        private void UpdateList()
        {
            lstMatches.Items.Add("Press Start Scan to begin.");
            _toScan = new List<Endpoint>();
            _scanned = new List<Endpoint>();
            _matched = new List<Endpoint>();

            if (_ranger == null) _ranger = new IpRanger();
            if (_ranger.Endpoints == null || _ranger.Endpoints.Count == 0) _ranger.UpdateEndpoints();
            _ranger.Endpoints.ForEach(e => _toScan.Add(e));
            lblCountToScanValue.Text = _toScan.Count.ToString();
            btnCopy.Enabled = false;
        }

        private void Load()
        {
            lstMatches.Items.Clear();
            lstMatches.Items.Add("Scanning...");
            _needClearPlaceholder = true;
            CancellationTokenStore = new CancellationTokenSource();
            ct = CancellationTokenStore.Token;

            var tester = new EndpointTester();

            var endpoints = _ranger.Endpoints;
            if (endpoints == null || endpoints.Count == 0)
            {
                _ranger.UpdateEndpoints();
                endpoints = _ranger.Endpoints;
            }

            taskArray = new Task[endpoints.Count];
            int count = 0;

            btnReset.Enabled = false;
            btnStartScan.Enabled = false;

            foreach(var item in endpoints)
            {
                item.Status = Constants.Constants.WaitThread;

                taskArray[count] = Task.Factory.StartNew(() =>
                {
                    item.Status = Constants.Constants.WaitResponse;

                    ct.ThrowIfCancellationRequested();
                    tester.TestEndpointAsync(item);

                    item.Status = (item.ExpectedStatusCode == item.ActualStatusCode)
                        ? Constants.Constants.InstanceFound
                        : Constants.Constants.NoInstance;

                    ExtThreadUpdateUI(item);
                }, ct);

                count++;
            }
        }

        private void lstMatches_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender != lstMatches) return;

            if (e.Control && e.KeyCode == Keys.C) CopySelectedValuesToClipboard();
        }

        private void CopySelectedValuesToClipboard()
        {
            var builder = new StringBuilder();
            foreach (ListViewItem item in lstMatches.SelectedItems) builder.AppendLine(item.Text);
            Clipboard.SetText(builder.ToString());
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstMatches.Items.Clear();
            UpdateList();
            UpdateUI(null);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopySelectedValuesToClipboard();
        }

        private void lstMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMatches.SelectedItems != null) btnCopy.Enabled = true;
            else btnCopy.Enabled = false;
        }
    }
}
