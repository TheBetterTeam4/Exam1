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
            button1 = new Button();
            label2 = new Label();
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
            // button1
            // 
            button1.Location = new Point(497, 826);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Next Page";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 830);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 861);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(uxPageText);
            Controls.Add(uxName);
            Name = "BookView";
            Text = "BookView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uxName;
        private Label uxPageText;
        private Button button1;
        private Label label2;
    }
}