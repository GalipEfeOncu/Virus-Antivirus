namespace Antivirus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnScan = new Button();
            lstResults = new ListBox();
            SuspendLayout();
            // 
            // btnScan
            // 
            btnScan.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScan.Location = new Point(12, 12);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(200, 70);
            btnScan.TabIndex = 0;
            btnScan.Text = "Scan System";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // lstResults
            // 
            lstResults.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstResults.FormattingEnabled = true;
            lstResults.ItemHeight = 21;
            lstResults.Location = new Point(12, 88);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(200, 109);
            lstResults.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 211);
            Controls.Add(lstResults);
            Controls.Add(btnScan);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnScan;
        private ListBox lstResults;
    }
}
