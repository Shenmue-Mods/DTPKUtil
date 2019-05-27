namespace DTPKutil
{
    partial class MainView
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnPickInput = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnPickOutput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnReadInfo = new System.Windows.Forms.Button();
            this.txtTrackInfo = new System.Windows.Forms.TextBox();
            this.btnDecompressAs = new System.Windows.Forms.Button();
            this.grpDecompress = new System.Windows.Forms.GroupBox();
            this.lblExplain32bit = new System.Windows.Forms.Label();
            this.chk32bit = new System.Windows.Forms.CheckBox();
            this.grpExtract = new System.Windows.Forms.GroupBox();
            this.grpDecompress.SuspendLayout();
            this.grpExtract.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(158, 23);
            this.txtInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(780, 31);
            this.txtInput.TabIndex = 1;
            // 
            // btnPickInput
            // 
            this.btnPickInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickInput.Location = new System.Drawing.Point(954, 19);
            this.btnPickInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPickInput.Name = "btnPickInput";
            this.btnPickInput.Size = new System.Drawing.Size(150, 44);
            this.btnPickInput.TabIndex = 2;
            this.btnPickInput.Text = "Browse...";
            this.btnPickInput.UseVisualStyleBackColor = true;
            this.btnPickInput.Click += new System.EventHandler(this.btnPickInput_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(24, 29);
            this.lblInput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(118, 25);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input track:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 35);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(201, 25);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "Extract to Directory:";
            // 
            // btnPickOutput
            // 
            this.btnPickOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickOutput.Location = new System.Drawing.Point(922, 25);
            this.btnPickOutput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPickOutput.Name = "btnPickOutput";
            this.btnPickOutput.Size = new System.Drawing.Size(150, 44);
            this.btnPickOutput.TabIndex = 2;
            this.btnPickOutput.Text = "Browse...";
            this.btnPickOutput.UseVisualStyleBackColor = true;
            this.btnPickOutput.Click += new System.EventHandler(this.btnPickOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(224, 29);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(682, 31);
            this.txtOutput.TabIndex = 1;
            // 
            // btnExtract
            // 
            this.btnExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtract.Location = new System.Drawing.Point(870, 81);
            this.btnExtract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(202, 44);
            this.btnExtract.TabIndex = 3;
            this.btnExtract.Text = "Extract Samples";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnReadInfo
            // 
            this.btnReadInfo.Location = new System.Drawing.Point(22, 348);
            this.btnReadInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReadInfo.Name = "btnReadInfo";
            this.btnReadInfo.Size = new System.Drawing.Size(240, 44);
            this.btnReadInfo.TabIndex = 5;
            this.btnReadInfo.Text = "Read Track Info";
            this.btnReadInfo.UseVisualStyleBackColor = true;
            this.btnReadInfo.Click += new System.EventHandler(this.btnReadInfo_Click);
            // 
            // txtTrackInfo
            // 
            this.txtTrackInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrackInfo.Location = new System.Drawing.Point(24, 404);
            this.txtTrackInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTrackInfo.Multiline = true;
            this.txtTrackInfo.Name = "txtTrackInfo";
            this.txtTrackInfo.ReadOnly = true;
            this.txtTrackInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTrackInfo.Size = new System.Drawing.Size(1076, 417);
            this.txtTrackInfo.TabIndex = 6;
            // 
            // btnDecompressAs
            // 
            this.btnDecompressAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecompressAs.Location = new System.Drawing.Point(834, 25);
            this.btnDecompressAs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDecompressAs.Name = "btnDecompressAs";
            this.btnDecompressAs.Size = new System.Drawing.Size(240, 44);
            this.btnDecompressAs.TabIndex = 1;
            this.btnDecompressAs.Text = "Decompress As...";
            this.btnDecompressAs.UseVisualStyleBackColor = true;
            this.btnDecompressAs.Click += new System.EventHandler(this.BtnDecompressAs_Click);
            // 
            // grpDecompress
            // 
            this.grpDecompress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDecompress.Controls.Add(this.lblExplain32bit);
            this.grpDecompress.Controls.Add(this.chk32bit);
            this.grpDecompress.Controls.Add(this.btnDecompressAs);
            this.grpDecompress.Location = new System.Drawing.Point(22, 71);
            this.grpDecompress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDecompress.Name = "grpDecompress";
            this.grpDecompress.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDecompress.Size = new System.Drawing.Size(1084, 119);
            this.grpDecompress.TabIndex = 3;
            this.grpDecompress.TabStop = false;
            this.grpDecompress.Text = "Create decompressed copy";
            // 
            // lblExplain32bit
            // 
            this.lblExplain32bit.AutoSize = true;
            this.lblExplain32bit.Location = new System.Drawing.Point(22, 75);
            this.lblExplain32bit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExplain32bit.Name = "lblExplain32bit";
            this.lblExplain32bit.Size = new System.Drawing.Size(846, 25);
            this.lblExplain32bit.TabIndex = 2;
            this.lblExplain32bit.Text = "This option is needed if converting for use in the PC versions, do not use on Dre" +
    "amcast";
            // 
            // chk32bit
            // 
            this.chk32bit.AutoSize = true;
            this.chk32bit.Location = new System.Drawing.Point(28, 35);
            this.chk32bit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chk32bit.Name = "chk32bit";
            this.chk32bit.Size = new System.Drawing.Size(362, 29);
            this.chk32bit.TabIndex = 0;
            this.chk32bit.Text = "Expand samples to playback rate";
            this.chk32bit.UseVisualStyleBackColor = true;
            // 
            // grpExtract
            // 
            this.grpExtract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExtract.Controls.Add(this.lblOutput);
            this.grpExtract.Controls.Add(this.txtOutput);
            this.grpExtract.Controls.Add(this.btnPickOutput);
            this.grpExtract.Controls.Add(this.btnExtract);
            this.grpExtract.Location = new System.Drawing.Point(22, 200);
            this.grpExtract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpExtract.Name = "grpExtract";
            this.grpExtract.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpExtract.Size = new System.Drawing.Size(1084, 137);
            this.grpExtract.TabIndex = 4;
            this.grpExtract.TabStop = false;
            this.grpExtract.Text = "Extract samples as .WAV";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 848);
            this.Controls.Add(this.grpExtract);
            this.Controls.Add(this.grpDecompress);
            this.Controls.Add(this.txtTrackInfo);
            this.Controls.Add(this.btnReadInfo);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnPickInput);
            this.Controls.Add(this.txtInput);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1134, 858);
            this.Name = "MainView";
            this.Text = "DTPK Util";
            this.grpDecompress.ResumeLayout(false);
            this.grpDecompress.PerformLayout();
            this.grpExtract.ResumeLayout(false);
            this.grpExtract.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnPickInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnPickOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnReadInfo;
        private System.Windows.Forms.TextBox txtTrackInfo;
        private System.Windows.Forms.Button btnDecompressAs;
        private System.Windows.Forms.GroupBox grpDecompress;
        private System.Windows.Forms.Label lblExplain32bit;
        private System.Windows.Forms.CheckBox chk32bit;
        private System.Windows.Forms.GroupBox grpExtract;
    }
}

