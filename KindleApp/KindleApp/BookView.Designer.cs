namespace KindleApp
{
    partial class BookView
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
            uxName = new Label();
            uxPageText = new Label();
            uxNextPage = new Button();
            uxPageNum = new Label();
            uxPrevPage = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            uxMark1 = new Button();
            uxMark2 = new Button();
            uxMark3 = new Button();
            uxMark4 = new Button();
            uxMark5 = new Button();
            uxMarkLabel = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            uxAddMark = new Button();
            uxRemoveMark = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uxName
            // 
            uxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uxName.AutoSize = true;
            uxName.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            uxName.Location = new Point(222, 9);
            uxName.Name = "uxName";
            uxName.Size = new Size(140, 32);
            uxName.TabIndex = 0;
            uxName.Text = "BookName";
            uxName.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxPageText
            // 
            uxPageText.Location = new Point(12, 67);
            uxPageText.Name = "uxPageText";
            uxPageText.Size = new Size(549, 585);
            uxPageText.TabIndex = 1;
            // 
            // uxNextPage
            // 
            uxNextPage.Location = new Point(497, 826);
            uxNextPage.Name = "uxNextPage";
            uxNextPage.Size = new Size(75, 23);
            uxNextPage.TabIndex = 2;
            uxNextPage.Text = "Next Page";
            uxNextPage.UseVisualStyleBackColor = true;
            uxNextPage.Click += uxNextPage_Click;
            // 
            // uxPageNum
            // 
            uxPageNum.AutoSize = true;
            uxPageNum.Location = new Point(279, 830);
            uxPageNum.Name = "uxPageNum";
            uxPageNum.Size = new Size(38, 15);
            uxPageNum.TabIndex = 3;
            uxPageNum.Text = "label2";
            // 
            // uxPrevPage
            // 
            uxPrevPage.Location = new Point(12, 826);
            uxPrevPage.Name = "uxPrevPage";
            uxPrevPage.Size = new Size(75, 23);
            uxPrevPage.TabIndex = 4;
            uxPrevPage.Text = "Prev Page";
            uxPrevPage.UseVisualStyleBackColor = true;
            uxPrevPage.Click += uxPrevPage_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(uxMark1);
            flowLayoutPanel1.Controls.Add(uxMark2);
            flowLayoutPanel1.Controls.Add(uxMark3);
            flowLayoutPanel1.Controls.Add(uxMark4);
            flowLayoutPanel1.Controls.Add(uxMark5);
            flowLayoutPanel1.Location = new Point(12, 687);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(253, 29);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // uxMark1
            // 
            uxMark1.Location = new Point(3, 3);
            uxMark1.Name = "uxMark1";
            uxMark1.Size = new Size(42, 23);
            uxMark1.TabIndex = 0;
            uxMark1.Text = "b1";
            uxMark1.UseVisualStyleBackColor = true;
            uxMark1.Visible = false;
            uxMark1.Click += uxMark1_Click;
            // 
            // uxMark2
            // 
            uxMark2.Location = new Point(51, 3);
            uxMark2.Name = "uxMark2";
            uxMark2.Size = new Size(42, 23);
            uxMark2.TabIndex = 1;
            uxMark2.Text = "b2";
            uxMark2.UseVisualStyleBackColor = true;
            uxMark2.Visible = false;
            uxMark2.Click += uxMark2_Click;
            // 
            // uxMark3
            // 
            uxMark3.Location = new Point(99, 3);
            uxMark3.Name = "uxMark3";
            uxMark3.Size = new Size(42, 23);
            uxMark3.TabIndex = 2;
            uxMark3.Text = "b3";
            uxMark3.UseVisualStyleBackColor = true;
            uxMark3.Visible = false;
            uxMark3.Click += uxMark3_Click;
            // 
            // uxMark4
            // 
            uxMark4.Location = new Point(147, 3);
            uxMark4.Name = "uxMark4";
            uxMark4.Size = new Size(42, 23);
            uxMark4.TabIndex = 3;
            uxMark4.Text = "b4";
            uxMark4.UseVisualStyleBackColor = true;
            uxMark4.Visible = false;
            uxMark4.Click += uxMark4_Click;
            // 
            // uxMark5
            // 
            uxMark5.Location = new Point(195, 3);
            uxMark5.Name = "uxMark5";
            uxMark5.Size = new Size(42, 23);
            uxMark5.TabIndex = 4;
            uxMark5.Text = "b5";
            uxMark5.UseVisualStyleBackColor = true;
            uxMark5.Visible = false;
            uxMark5.Click += uxMark5_Click;
            // 
            // uxMarkLabel
            // 
            uxMarkLabel.AutoSize = true;
            uxMarkLabel.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            uxMarkLabel.Location = new Point(15, 659);
            uxMarkLabel.Name = "uxMarkLabel";
            uxMarkLabel.Size = new Size(105, 25);
            uxMarkLabel.TabIndex = 6;
            uxMarkLabel.Text = "BookMarks";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(uxAddMark);
            flowLayoutPanel2.Controls.Add(uxRemoveMark);
            flowLayoutPanel2.Location = new Point(12, 719);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(253, 29);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // uxAddMark
            // 
            uxAddMark.Location = new Point(3, 3);
            uxAddMark.Name = "uxAddMark";
            uxAddMark.Size = new Size(105, 23);
            uxAddMark.TabIndex = 0;
            uxAddMark.Text = "Add Bookmark";
            uxAddMark.UseVisualStyleBackColor = true;
            uxAddMark.Click += uxAddMark_Click;
            // 
            // uxRemoveMark
            // 
            uxRemoveMark.Location = new Point(114, 3);
            uxRemoveMark.Name = "uxRemoveMark";
            uxRemoveMark.Size = new Size(115, 23);
            uxRemoveMark.TabIndex = 1;
            uxRemoveMark.Text = "Remove Bookmark";
            uxRemoveMark.UseVisualStyleBackColor = true;
            uxRemoveMark.Click += uxRemoveMark_Click;
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 861);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(uxMarkLabel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(uxPrevPage);
            Controls.Add(uxPageNum);
            Controls.Add(uxNextPage);
            Controls.Add(uxPageText);
            Controls.Add(uxName);
            Name = "BookView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookView";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uxName;
        private Label uxPageText;
        private Button uxNextPage;
        private Label uxPageNum;
        private Button uxPrevPage;
        private FlowLayoutPanel flowLayoutPanel1;
        public Button uxMark1;
        public Button uxMark2;
        public Button uxMark3;
        public Button uxMark4;
        public Button uxMark5;
        private Label uxMarkLabel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button uxAddMark;
        private Button uxRemoveMark;
    }
}