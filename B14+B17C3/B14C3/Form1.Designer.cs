namespace B14C3
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            cậpToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtLớpAToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtLớpBToolStripMenuItem = new ToolStripMenuItem();
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem = new ToolStripMenuItem();
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem = new ToolStripMenuItem();
            chuyểnHếtDanhSáchSangLớpAToolStripMenuItem = new ToolStripMenuItem();
            chuyểnHếtDanhSáchSangLớpBToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            xóaDanhSáchLớpAToolStripMenuItem = new ToolStripMenuItem();
            xóaDanhSáchLớpBToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            kếtThúcToolStripMenuItem = new ToolStripMenuItem();
            lblTen = new Label();
            txtTen = new TextBox();
            updateBtn = new Button();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            moveRightButton = new Button();
            moveRightAllButton = new Button();
            moveLeftButton = new Button();
            moveLeftAllButton = new Button();
            deleteAButton = new Button();
            endBtn = new Button();
            deleteBButton = new Button();
            statusStrip1 = new StatusStrip();
            lblDateTime = new ToolStripStatusLabel();
            lblName = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Cyan;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpToolStripMenuItem
            // 
            cậpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cậpNhậtLớpAToolStripMenuItem, cậpNhậtLớpBToolStripMenuItem, chuyểnPhầnTửChọnSangLớpAToolStripMenuItem, chuyểnPhầnTửChọnSangLớpBToolStripMenuItem, chuyểnHếtDanhSáchSangLớpAToolStripMenuItem, chuyểnHếtDanhSáchSangLớpBToolStripMenuItem, toolStripMenuItem1, xóaDanhSáchLớpAToolStripMenuItem, xóaDanhSáchLớpBToolStripMenuItem });
            cậpToolStripMenuItem.Name = "cậpToolStripMenuItem";
            cậpToolStripMenuItem.Size = new Size(85, 24);
            cậpToolStripMenuItem.Text = "Cập Nhật";
            // 
            // cậpNhậtLớpAToolStripMenuItem
            // 
            cậpNhậtLớpAToolStripMenuItem.Name = "cậpNhậtLớpAToolStripMenuItem";
            cậpNhậtLớpAToolStripMenuItem.Size = new Size(315, 26);
            cậpNhậtLớpAToolStripMenuItem.Text = "Cập Nhật Lớp A";
            // 
            // cậpNhậtLớpBToolStripMenuItem
            // 
            cậpNhậtLớpBToolStripMenuItem.Name = "cậpNhậtLớpBToolStripMenuItem";
            cậpNhậtLớpBToolStripMenuItem.Size = new Size(315, 26);
            cậpNhậtLớpBToolStripMenuItem.Text = "Cập Nhật Lớp B";
            // 
            // chuyểnPhầnTửChọnSangLớpAToolStripMenuItem
            // 
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpAToolStripMenuItem";
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Size = new Size(315, 26);
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Text = "Chuyển Phần Tử Chọn Sang Lớp A";
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Click += chuyểnPhầnTửChọnSangLớpAToolStripMenuItem_Click;
            // 
            // chuyểnPhầnTửChọnSangLớpBToolStripMenuItem
            // 
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpBToolStripMenuItem";
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Size = new Size(315, 26);
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Text = "Chuyển Phần Tử Chọn Sang Lớp B";
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Click += chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click;
            // 
            // chuyểnHếtDanhSáchSangLớpAToolStripMenuItem
            // 
            chuyểnHếtDanhSáchSangLớpAToolStripMenuItem.Name = "chuyểnHếtDanhSáchSangLớpAToolStripMenuItem";
            chuyểnHếtDanhSáchSangLớpAToolStripMenuItem.Size = new Size(315, 26);
            chuyểnHếtDanhSáchSangLớpAToolStripMenuItem.Text = "Chuyển hết danh sách sang lớp A";
            chuyểnHếtDanhSáchSangLớpAToolStripMenuItem.Click += chuyểnHếtDanhSáchSangLớpAToolStripMenuItem_Click;
            // 
            // chuyểnHếtDanhSáchSangLớpBToolStripMenuItem
            // 
            chuyểnHếtDanhSáchSangLớpBToolStripMenuItem.Name = "chuyểnHếtDanhSáchSangLớpBToolStripMenuItem";
            chuyểnHếtDanhSáchSangLớpBToolStripMenuItem.Size = new Size(315, 26);
            chuyểnHếtDanhSáchSangLớpBToolStripMenuItem.Text = "Chuyển hết danh sách sang lớp B";
            chuyểnHếtDanhSáchSangLớpBToolStripMenuItem.Click += chuyểnHếtDanhSáchSangLớpBToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(312, 6);
            // 
            // xóaDanhSáchLớpAToolStripMenuItem
            // 
            xóaDanhSáchLớpAToolStripMenuItem.Name = "xóaDanhSáchLớpAToolStripMenuItem";
            xóaDanhSáchLớpAToolStripMenuItem.Size = new Size(315, 26);
            xóaDanhSáchLớpAToolStripMenuItem.Text = "Xóa Danh Sách Lớp A";
            xóaDanhSáchLớpAToolStripMenuItem.Click += xóaDanhSáchLớpAToolStripMenuItem_Click;
            // 
            // xóaDanhSáchLớpBToolStripMenuItem
            // 
            xóaDanhSáchLớpBToolStripMenuItem.Name = "xóaDanhSáchLớpBToolStripMenuItem";
            xóaDanhSáchLớpBToolStripMenuItem.Size = new Size(315, 26);
            xóaDanhSáchLớpBToolStripMenuItem.Text = "Xóa Danh Sách Lớp B";
            xóaDanhSáchLớpBToolStripMenuItem.Click += xóaDanhSáchLớpBToolStripMenuItem_Click;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinToolStripMenuItem, kếtThúcToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(224, 26);
            thôngTinToolStripMenuItem.Text = "Thông Tin";
            thôngTinToolStripMenuItem.Click += thôngTinToolStripMenuItem_Click;
            // 
            // kếtThúcToolStripMenuItem
            // 
            kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            kếtThúcToolStripMenuItem.Size = new Size(224, 26);
            kếtThúcToolStripMenuItem.Text = "Kết Thúc";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.BackColor = SystemColors.Control;
            lblTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTen.Location = new Point(34, 50);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(60, 20);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên SV:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(112, 47);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(344, 27);
            txtTen.TabIndex = 2;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            updateBtn.Location = new Point(518, 42);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(222, 36);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Cập nhật";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(34, 95);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(183, 184);
            lstLopA.TabIndex = 4;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(532, 95);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(183, 184);
            lstLopB.TabIndex = 5;
            // 
            // moveRightButton
            // 
            moveRightButton.Location = new Point(319, 102);
            moveRightButton.Name = "moveRightButton";
            moveRightButton.Size = new Size(88, 25);
            moveRightButton.TabIndex = 6;
            moveRightButton.Text = ">";
            moveRightButton.UseVisualStyleBackColor = true;
            moveRightButton.Click += moveRightButton_Click;
            // 
            // moveRightAllButton
            // 
            moveRightAllButton.Location = new Point(319, 133);
            moveRightAllButton.Name = "moveRightAllButton";
            moveRightAllButton.Size = new Size(88, 25);
            moveRightAllButton.TabIndex = 7;
            moveRightAllButton.Text = ">>";
            moveRightAllButton.UseVisualStyleBackColor = true;
            moveRightAllButton.Click += moveRightAllButton_Click;
            // 
            // moveLeftButton
            // 
            moveLeftButton.Location = new Point(319, 223);
            moveLeftButton.Name = "moveLeftButton";
            moveLeftButton.Size = new Size(88, 25);
            moveLeftButton.TabIndex = 8;
            moveLeftButton.Text = "<";
            moveLeftButton.UseVisualStyleBackColor = true;
            moveLeftButton.Click += moveLeftButton_Click;
            // 
            // moveLeftAllButton
            // 
            moveLeftAllButton.Location = new Point(319, 254);
            moveLeftAllButton.Name = "moveLeftAllButton";
            moveLeftAllButton.Size = new Size(88, 25);
            moveLeftAllButton.TabIndex = 9;
            moveLeftAllButton.Text = "<<";
            moveLeftAllButton.UseVisualStyleBackColor = true;
            moveLeftAllButton.Click += moveLeftAllButton_Click;
            // 
            // deleteAButton
            // 
            deleteAButton.Location = new Point(129, 328);
            deleteAButton.Name = "deleteAButton";
            deleteAButton.Size = new Size(88, 25);
            deleteAButton.TabIndex = 10;
            deleteAButton.Text = "Xóa lớp A";
            deleteAButton.UseVisualStyleBackColor = true;
            deleteAButton.Click += deleteAButton_Click;
            // 
            // endBtn
            // 
            endBtn.Location = new Point(331, 328);
            endBtn.Name = "endBtn";
            endBtn.Size = new Size(88, 25);
            endBtn.TabIndex = 11;
            endBtn.Text = "Kết thúc";
            endBtn.UseVisualStyleBackColor = true;
            endBtn.Click += endBtn_Click;
            // 
            // deleteBButton
            // 
            deleteBButton.Location = new Point(532, 328);
            deleteBButton.Name = "deleteBButton";
            deleteBButton.Size = new Size(88, 25);
            deleteBButton.TabIndex = 12;
            deleteBButton.Text = "Xóa lớp B";
            deleteBButton.UseVisualStyleBackColor = true;
            deleteBButton.Click += deleteBButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Cyan;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblDateTime, lblName });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblDateTime
            // 
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(0, 20);
            // 
            // lblName
            // 
            lblName.Name = "lblName";
            lblName.Size = new Size(141, 20);
            lblName.Text = "Designed by Aurora";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(deleteBButton);
            Controls.Add(endBtn);
            Controls.Add(deleteAButton);
            Controls.Add(moveLeftAllButton);
            Controls.Add(moveLeftButton);
            Controls.Add(moveRightAllButton);
            Controls.Add(moveRightButton);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(updateBtn);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Cập Nhật 2 Listbox";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private Label lblTen;
        private TextBox txtTen;
        private Button updateBtn;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button moveRightButton;
        private Button moveRightAllButton;
        private Button moveLeftButton;
        private Button moveLeftAllButton;
        private Button deleteAButton;
        private Button endBtn;
        private Button deleteBButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblDateTime;
        private ToolStripStatusLabel lblName;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem cậpNhậtLớpAToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtLớpBToolStripMenuItem;
        private ToolStripMenuItem chuyểnPhầnTửChọnSangLớpAToolStripMenuItem;
        private ToolStripMenuItem chuyểnPhầnTửChọnSangLớpBToolStripMenuItem;
        private ToolStripMenuItem chuyểnHếtDanhSáchSangLớpAToolStripMenuItem;
        private ToolStripMenuItem chuyểnHếtDanhSáchSangLớpBToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem xóaDanhSáchLớpAToolStripMenuItem;
        private ToolStripMenuItem xóaDanhSáchLớpBToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem kếtThúcToolStripMenuItem;
    }
}
