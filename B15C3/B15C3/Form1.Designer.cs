namespace B15C3
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
            lblColor = new Label();
            lblSize = new Label();
            lblSampleText = new Label();
            dudColor = new DomainUpDown();
            nudSize = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            SuspendLayout();
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(122, 77);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(48, 20);
            lblColor.TabIndex = 0;
            lblColor.Text = "Color:";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(122, 140);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(39, 20);
            lblSize.TabIndex = 1;
            lblSize.Text = "Size:";
            // 
            // lblSampleText
            // 
            lblSampleText.AutoSize = true;
            lblSampleText.Font = new Font("Segoe UI", 22F);
            lblSampleText.Location = new Point(272, 279);
            lblSampleText.Name = "lblSampleText";
            lblSampleText.Size = new Size(246, 50);
            lblSampleText.TabIndex = 2;
            lblSampleText.Text = "SAMPLE TEXT";
            // 
            // dudColor
            // 
            dudColor.Location = new Point(284, 79);
            dudColor.Name = "dudColor";
            dudColor.RightToLeft = RightToLeft.Yes;
            dudColor.Size = new Size(317, 27);
            dudColor.TabIndex = 5;
            dudColor.SelectedItemChanged += dudColor_SelectedItemChanged;
            // 
            // nudSize
            // 
            nudSize.BackColor = SystemColors.ActiveBorder;
            nudSize.ForeColor = SystemColors.ActiveCaptionText;
            nudSize.Location = new Point(284, 140);
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(317, 27);
            nudSize.TabIndex = 6;
            nudSize.ValueChanged += nudSize_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(nudSize);
            Controls.Add(dudColor);
            Controls.Add(lblSampleText);
            Controls.Add(lblSize);
            Controls.Add(lblColor);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblColor;
        private Label lblSize;
        private Label lblSampleText;
        private DomainUpDown dudColor;
        private NumericUpDown nudSize;
    }
}
