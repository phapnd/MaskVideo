namespace ExtVideo
{
    partial class Main
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVideoInput = new System.Windows.Forms.TextBox();
            this.btFileInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVideoOutput = new System.Windows.Forms.TextBox();
            this.btFileOutput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMetadataFile = new System.Windows.Forms.TextBox();
            this.btFileMeta = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btRender = new System.Windows.Forms.Button();
            this.btExtract = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtVideoInput);
            this.flowLayoutPanel1.Controls.Add(this.btFileInput);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtVideoOutput);
            this.flowLayoutPanel1.Controls.Add(this.btFileOutput);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtMetadataFile);
            this.flowLayoutPanel1.Controls.Add(this.btFileMeta);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(497, 85);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video Input    ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVideoInput
            // 
            this.txtVideoInput.Location = new System.Drawing.Point(82, 3);
            this.txtVideoInput.Name = "txtVideoInput";
            this.txtVideoInput.Size = new System.Drawing.Size(363, 20);
            this.txtVideoInput.TabIndex = 1;
            // 
            // btFileInput
            // 
            this.btFileInput.Location = new System.Drawing.Point(451, 3);
            this.btFileInput.Name = "btFileInput";
            this.btFileInput.Size = new System.Drawing.Size(28, 23);
            this.btFileInput.TabIndex = 4;
            this.btFileInput.Text = "...";
            this.btFileInput.UseVisualStyleBackColor = true;
            this.btFileInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btFileInput_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Video Output ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVideoOutput
            // 
            this.txtVideoOutput.Location = new System.Drawing.Point(81, 32);
            this.txtVideoOutput.Name = "txtVideoOutput";
            this.txtVideoOutput.Size = new System.Drawing.Size(364, 20);
            this.txtVideoOutput.TabIndex = 3;
            // 
            // btFileOutput
            // 
            this.btFileOutput.Location = new System.Drawing.Point(451, 32);
            this.btFileOutput.Name = "btFileOutput";
            this.btFileOutput.Size = new System.Drawing.Size(28, 23);
            this.btFileOutput.TabIndex = 5;
            this.btFileOutput.Text = "...";
            this.btFileOutput.UseVisualStyleBackColor = true;
            this.btFileOutput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btFileOutput_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Metadata File";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMetadataFile
            // 
            this.txtMetadataFile.Location = new System.Drawing.Point(80, 61);
            this.txtMetadataFile.Name = "txtMetadataFile";
            this.txtMetadataFile.Size = new System.Drawing.Size(365, 20);
            this.txtMetadataFile.TabIndex = 7;
            // 
            // btFileMeta
            // 
            this.btFileMeta.Location = new System.Drawing.Point(451, 61);
            this.btFileMeta.Name = "btFileMeta";
            this.btFileMeta.Size = new System.Drawing.Size(28, 23);
            this.btFileMeta.TabIndex = 8;
            this.btFileMeta.Text = "...";
            this.btFileMeta.UseVisualStyleBackColor = true;
            this.btFileMeta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btFileMeta_MouseClick);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(419, 3);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btExit_MouseClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.btExit);
            this.flowLayoutPanel2.Controls.Add(this.btRender);
            this.flowLayoutPanel2.Controls.Add(this.btExtract);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 130);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(497, 36);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btRender
            // 
            this.btRender.Location = new System.Drawing.Point(338, 3);
            this.btRender.Name = "btRender";
            this.btRender.Size = new System.Drawing.Size(75, 23);
            this.btRender.TabIndex = 10;
            this.btRender.Text = "Render";
            this.btRender.UseVisualStyleBackColor = true;
            this.btRender.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btRender_MouseClick);
            // 
            // btExtract
            // 
            this.btExtract.Location = new System.Drawing.Point(257, 3);
            this.btExtract.Name = "btExtract";
            this.btExtract.Size = new System.Drawing.Size(75, 23);
            this.btExtract.TabIndex = 11;
            this.btExtract.Text = "Extract";
            this.btExtract.UseVisualStyleBackColor = true;
            this.btExtract.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btExtract_MouseClick);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Location = new System.Drawing.Point(4, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(497, 4);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(513, 169);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Render";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVideoInput;
        private System.Windows.Forms.Button btFileInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVideoOutput;
        private System.Windows.Forms.Button btFileOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMetadataFile;
        private System.Windows.Forms.Button btFileMeta;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btRender;
        private System.Windows.Forms.Button btExtract;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}

