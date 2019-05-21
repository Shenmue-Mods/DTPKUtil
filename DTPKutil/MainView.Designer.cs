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
            this.chk32bit = new System.Windows.Forms.CheckBox();
            this.lblExplain32bit = new System.Windows.Forms.Label();
            this.grpExtract = new System.Windows.Forms.GroupBox();
            this.grpDecompress.SuspendLayout();
            this.grpExtract.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(79, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(392, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnPickInput
            // 
            this.btnPickInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickInput.Location = new System.Drawing.Point(477, 10);
            this.btnPickInput.Name = "btnPickInput";
            this.btnPickInput.Size = new System.Drawing.Size(75, 23);
            this.btnPickInput.TabIndex = 2;
            this.btnPickInput.Text = "Browse...";
            this.btnPickInput.UseVisualStyleBackColor = true;
            this.btnPickInput.Click += new System.EventHandler(this.btnPickInput_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 15);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(61, 13);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input track:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(6, 18);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 13);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "Extract to Directory:";
            // 
            // btnPickOutput
            // 
            this.btnPickOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickOutput.Location = new System.Drawing.Point(461, 13);
            this.btnPickOutput.Name = "btnPickOutput";
            this.btnPickOutput.Size = new System.Drawing.Size(75, 23);
            this.btnPickOutput.TabIndex = 2;
            this.btnPickOutput.Text = "Browse...";
            this.btnPickOutput.UseVisualStyleBackColor = true;
            this.btnPickOutput.Click += new System.EventHandler(this.btnPickOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(112, 15);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(343, 20);
            this.txtOutput.TabIndex = 1;
            // 
            // btnExtract
            // 
            this.btnExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtract.Location = new System.Drawing.Point(435, 42);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(101, 23);
            this.btnExtract.TabIndex = 3;
            this.btnExtract.Text = "Extract Samples";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnReadInfo
            // 
            this.btnReadInfo.Location = new System.Drawing.Point(11, 181);
            this.btnReadInfo.Name = "btnReadInfo";
            this.btnReadInfo.Size = new System.Drawing.Size(120, 23);
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
            this.txtTrackInfo.Location = new System.Drawing.Point(12, 210);
            this.txtTrackInfo.Multiline = true;
            this.txtTrackInfo.Name = "txtTrackInfo";
            this.txtTrackInfo.ReadOnly = true;
            this.txtTrackInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTrackInfo.Size = new System.Drawing.Size(540, 219);
            this.txtTrackInfo.TabIndex = 6;
            // 
            // btnDecompressAs
            // 
            this.btnDecompressAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecompressAs.Location = new System.Drawing.Point(417, 13);
            this.btnDecompressAs.Name = "btnDecompressAs";
            this.btnDecompressAs.Size = new System.Drawing.Size(120, 23);
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
            this.grpDecompress.Location = new System.Drawing.Point(11, 37);
            this.grpDecompress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDecompress.Name = "grpDecompress";
            this.grpDecompress.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDecompress.Size = new System.Drawing.Size(542, 62);
            this.grpDecompress.TabIndex = 3;
            this.grpDecompress.TabStop = false;
            this.grpDecompress.Text = "Create decompressed copy";
            // 
            // chk32bit
            // 
            this.chk32bit.AutoSize = true;
            this.chk32bit.Location = new System.Drawing.Point(14, 18);
            this.chk32bit.Name = "chk32bit";
            this.chk32bit.Size = new System.Drawing.Size(144, 17);
            this.chk32bit.TabIndex = 0;
            this.chk32bit.Text = "Expand samples to 32-bit";
            this.chk32bit.UseVisualStyleBackColor = true;
            // 
            // lblExplain32bit
            // 
            this.lblExplain32bit.AutoSize = true;
            this.lblExplain32bit.Location = new System.Drawing.Point(11, 39);
            this.lblExplain32bit.Name = "lblExplain32bit";
            this.lblExplain32bit.Size = new System.Drawing.Size(522, 13);
            this.lblExplain32bit.TabIndex = 2;
            this.lblExplain32bit.Text = "32-bit samples are only used by the PC version of Shenmue 1. For Dreamcast or She" +
    "nmue 2 PC leave this off.";
            // 
            // grpExtract
            // 
            this.grpExtract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExtract.Controls.Add(this.lblOutput);
            this.grpExtract.Controls.Add(this.txtOutput);
            this.grpExtract.Controls.Add(this.btnPickOutput);
            this.grpExtract.Controls.Add(this.btnExtract);
            this.grpExtract.Location = new System.Drawing.Point(11, 104);
            this.grpExtract.Name = "grpExtract";
            this.grpExtract.Size = new System.Drawing.Size(542, 71);
            this.grpExtract.TabIndex = 4;
            this.grpExtract.TabStop = false;
            this.grpExtract.Text = "Extract samples as .WAV";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 441);
            this.Controls.Add(this.grpExtract);
            this.Controls.Add(this.grpDecompress);
            this.Controls.Add(this.txtTrackInfo);
            this.Controls.Add(this.btnReadInfo);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnPickInput);
            this.Controls.Add(this.txtInput);
            this.MinimumSize = new System.Drawing.Size(580, 480);
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

