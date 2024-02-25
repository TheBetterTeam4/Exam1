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
            uxPageText.Location = new Point(12, 65);
            uxPageText.Name = "uxPageText";
            uxPageText.Size = new Size(560, 732);
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
            // BookView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 861);
            Controls.Add(uxPrevPage);
            Controls.Add(uxPageNum);
            Controls.Add(uxNextPage);
            Controls.Add(uxPageText);
            Controls.Add(uxName);
            Name = "BookView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uxName;
        private Label uxPageText;
        private Button uxNextPage;
        private Label uxPageNum;
        private Button uxPrevPage;
    }
}