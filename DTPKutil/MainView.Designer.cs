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
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(79, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(282, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnPickInput
            // 
            this.btnPickInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickInput.Location = new System.Drawing.Point(367, 10);
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
            this.lblOutput.Location = new System.Drawing.Point(12, 82);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Extract to Directory:";
            // 
            // btnPickOutput
            // 
            this.btnPickOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickOutput.Location = new System.Drawing.Point(260, 77);
            this.btnPickOutput.Name = "btnPickOutput";
            this.btnPickOutput.Size = new System.Drawing.Size(75, 23);
            this.btnPickOutput.TabIndex = 7;
            this.btnPickOutput.Text = "Browse...";
            this.btnPickOutput.UseVisualStyleBackColor = true;
            this.btnPickOutput.Click += new System.EventHandler(this.btnPickOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(118, 79);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(136, 20);
            this.txtOutput.TabIndex = 6;
            // 
            // btnExtract
            // 
            this.btnExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtract.Location = new System.Drawing.Point(341, 77);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(101, 23);
            this.btnExtract.TabIndex = 8;
            this.btnExtract.Text = "Extract Samples";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnReadInfo
            // 
            this.btnReadInfo.Location = new System.Drawing.Point(79, 38);
            this.btnReadInfo.Name = "btnReadInfo";
            this.btnReadInfo.Size = new System.Drawing.Size(120, 23);
            this.btnReadInfo.TabIndex = 3;
            this.btnReadInfo.Text = "Read Track Info";
            this.btnReadInfo.UseVisualStyleBackColor = true;
            this.btnReadInfo.Click += new System.EventHandler(this.btnReadInfo_Click);
            // 
            // txtTrackInfo
            // 
            this.txtTrackInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrackInfo.Location = new System.Drawing.Point(12, 106);
            this.txtTrackInfo.Multiline = true;
            this.txtTrackInfo.Name = "txtTrackInfo";
            this.txtTrackInfo.ReadOnly = true;
            this.txtTrackInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTrackInfo.Size = new System.Drawing.Size(430, 243);
            this.txtTrackInfo.TabIndex = 9;
            // 
            // btnDecompressAs
            // 
            this.btnDecompressAs.Location = new System.Drawing.Point(205, 38);
            this.btnDecompressAs.Name = "btnDecompressAs";
            this.btnDecompressAs.Size = new System.Drawing.Size(120, 23);
            this.btnDecompressAs.TabIndex = 4;
            this.btnDecompressAs.Text = "Decompress As...";
            this.btnDecompressAs.UseVisualStyleBackColor = true;
            this.btnDecompressAs.Click += new System.EventHandler(this.BtnDecompressAs_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 361);
            this.Controls.Add(this.btnDecompressAs);
            this.Controls.Add(this.txtTrackInfo);
            this.Controls.Add(this.btnReadInfo);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnPickOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnPickInput);
            this.Controls.Add(this.txtInput);
            this.Name = "MainView";
            this.Text = "DTPK Util";
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
    }
}

