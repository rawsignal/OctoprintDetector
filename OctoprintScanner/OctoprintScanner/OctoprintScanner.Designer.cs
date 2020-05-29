namespace OctoprintScanner
{
    partial class OctoprintScanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.applicationLogo = new System.Windows.Forms.PictureBox();
            this.headingLabel = new System.Windows.Forms.Label();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setOctoprintEndpointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblToScanCountKey = new System.Windows.Forms.Label();
            this.lblCountScannedKey = new System.Windows.Forms.Label();
            this.lblCountToScanValue = new System.Windows.Forms.Label();
            this.lblCntScanned = new System.Windows.Forms.Label();
            this.lstMatches = new System.Windows.Forms.ListView();
            this.lblMatches = new System.Windows.Forms.Label();
            this.lblCountFound = new System.Windows.Forms.Label();
            this.lblCountIdent = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.applicationLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicationLogo
            // 
            this.applicationLogo.ImageLocation = "C:\\Users\\logan\\OneDrive\\Pictures\\21687925_1979439268982443_4725346301701097946_n." +
    "png";
            this.applicationLogo.Location = new System.Drawing.Point(12, 60);
            this.applicationLogo.Name = "applicationLogo";
            this.applicationLogo.Size = new System.Drawing.Size(108, 101);
            this.applicationLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.applicationLogo.TabIndex = 0;
            this.applicationLogo.TabStop = false;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(8, 24);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(479, 24);
            this.headingLabel.TabIndex = 3;
            this.headingLabel.Text = "SP3DP OctoPrint/PrusaPrint Instance Scanner";
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(348, 343);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(75, 23);
            this.btnStartScan.TabIndex = 4;
            this.btnStartScan.Text = "Start Scan";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setOctoprintEndpointToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // setOctoprintEndpointToolStripMenuItem
            // 
            this.setOctoprintEndpointToolStripMenuItem.Enabled = false;
            this.setOctoprintEndpointToolStripMenuItem.Name = "setOctoprintEndpointToolStripMenuItem";
            this.setOctoprintEndpointToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.setOctoprintEndpointToolStripMenuItem.Text = "Set Octoprint Endpoint";
            // 
            // lblToScanCountKey
            // 
            this.lblToScanCountKey.AutoSize = true;
            this.lblToScanCountKey.Location = new System.Drawing.Point(126, 77);
            this.lblToScanCountKey.Name = "lblToScanCountKey";
            this.lblToScanCountKey.Size = new System.Drawing.Size(140, 13);
            this.lblToScanCountKey.TabIndex = 8;
            this.lblToScanCountKey.Text = "Count of Endpoints to Scan:";
            // 
            // lblCountScannedKey
            // 
            this.lblCountScannedKey.AutoSize = true;
            this.lblCountScannedKey.Location = new System.Drawing.Point(126, 102);
            this.lblCountScannedKey.Name = "lblCountScannedKey";
            this.lblCountScannedKey.Size = new System.Drawing.Size(149, 13);
            this.lblCountScannedKey.TabIndex = 9;
            this.lblCountScannedKey.Text = "Count of Endpoints Scanned: ";
            // 
            // lblCountToScanValue
            // 
            this.lblCountToScanValue.AutoSize = true;
            this.lblCountToScanValue.Location = new System.Drawing.Point(287, 77);
            this.lblCountToScanValue.Name = "lblCountToScanValue";
            this.lblCountToScanValue.Size = new System.Drawing.Size(13, 13);
            this.lblCountToScanValue.TabIndex = 10;
            this.lblCountToScanValue.Text = "0";
            // 
            // lblCntScanned
            // 
            this.lblCntScanned.AutoSize = true;
            this.lblCntScanned.Location = new System.Drawing.Point(287, 102);
            this.lblCntScanned.Name = "lblCntScanned";
            this.lblCntScanned.Size = new System.Drawing.Size(13, 13);
            this.lblCntScanned.TabIndex = 11;
            this.lblCntScanned.Text = "0";
            // 
            // lstMatches
            // 
            this.lstMatches.HideSelection = false;
            this.lstMatches.Location = new System.Drawing.Point(61, 190);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(362, 144);
            this.lstMatches.TabIndex = 12;
            this.lstMatches.UseCompatibleStateImageBehavior = false;
            this.lstMatches.View = System.Windows.Forms.View.List;
            this.lstMatches.SelectedIndexChanged += new System.EventHandler(this.lstMatches_SelectedIndexChanged);
            this.lstMatches.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMatches_KeyDown);
            // 
            // lblMatches
            // 
            this.lblMatches.AutoSize = true;
            this.lblMatches.Location = new System.Drawing.Point(68, 174);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(103, 13);
            this.lblMatches.TabIndex = 13;
            this.lblMatches.Text = "Identified Endpoints:";
            // 
            // lblCountFound
            // 
            this.lblCountFound.AutoSize = true;
            this.lblCountFound.Location = new System.Drawing.Point(126, 124);
            this.lblCountFound.Name = "lblCountFound";
            this.lblCountFound.Size = new System.Drawing.Size(146, 13);
            this.lblCountFound.TabIndex = 14;
            this.lblCountFound.Text = "Count of Identified Endpoints:";
            // 
            // lblCountIdent
            // 
            this.lblCountIdent.AutoSize = true;
            this.lblCountIdent.Location = new System.Drawing.Point(287, 124);
            this.lblCountIdent.Name = "lblCountIdent";
            this.lblCountIdent.Size = new System.Drawing.Size(13, 13);
            this.lblCountIdent.TabIndex = 15;
            this.lblCountIdent.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(259, 343);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(61, 343);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(120, 23);
            this.btnCopy.TabIndex = 17;
            this.btnCopy.Text = "Copy To Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // OctoprintScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 378);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblCountIdent);
            this.Controls.Add(this.lblCountFound);
            this.Controls.Add(this.lblMatches);
            this.Controls.Add(this.lstMatches);
            this.Controls.Add(this.lblCntScanned);
            this.Controls.Add(this.lblCountToScanValue);
            this.Controls.Add(this.lblCountScannedKey);
            this.Controls.Add(this.lblToScanCountKey);
            this.Controls.Add(this.btnStartScan);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.applicationLogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OctoprintScanner";
            this.Text = "OctoprintScanner";
            ((System.ComponentModel.ISupportInitialize)(this.applicationLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox applicationLogo;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setOctoprintEndpointToolStripMenuItem;
        private System.Windows.Forms.Label lblToScanCountKey;
        private System.Windows.Forms.Label lblCountScannedKey;
        private System.Windows.Forms.Label lblCountToScanValue;
        private System.Windows.Forms.Label lblCntScanned;
        private System.Windows.Forms.ListView lstMatches;
        private System.Windows.Forms.Label lblMatches;
        private System.Windows.Forms.Label lblCountFound;
        private System.Windows.Forms.Label lblCountIdent;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCopy;
    }
}

