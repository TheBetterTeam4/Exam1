using System.Xml.Linq;

namespace KindleApp
{
    partial class LibraryView
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
            uxName = new Label();
            UxBookList = new ListBox();
            uxSynchronize = new Button();
            SuspendLayout();
            // 
            // uxName
            // 
            uxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uxName.AutoSize = true;
            uxName.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            uxName.Location = new Point(222, 9);
            uxName.Name = "uxName";
            uxName.Size = new Size(136, 32);
            uxName.TabIndex = 0;
            uxName.Text = "My Library";
            uxName.TextAlign = ContentAlignment.TopCenter;
            // 
            // UxBookList
            // 
            UxBookList.Font = new Font("Segoe UI Historic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            UxBookList.FormattingEnabled = true;
            UxBookList.ItemHeight = 28;
            UxBookList.Location = new Point(55, 59);
            UxBookList.Name = "UxBookList";
            UxBookList.Size = new Size(477, 620);
            UxBookList.TabIndex = 1;
            // 
            // uxSynchronize
            // 
            uxSynchronize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uxSynchronize.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uxSynchronize.Font = new Font("Segoe UI Historic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            uxSynchronize.Location = new Point(222, 685);
            uxSynchronize.Name = "uxSynchronize";
            uxSynchronize.Size = new Size(136, 34);
            uxSynchronize.TabIndex = 2;
            uxSynchronize.Text = "Synchronize";
            uxSynchronize.TextAlign = ContentAlignment.TopCenter;
            uxSynchronize.UseVisualStyleBackColor = true;
            // 
            // LibraryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 861);
            Controls.Add(uxSynchronize);
            Controls.Add(UxBookList);
            Controls.Add(uxName);
            Name = "LibraryView";
            Text = "BookView";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label uxName;
        #endregion

        private ListBox UxBookList;
        private Button uxSynchronize;
    }
}