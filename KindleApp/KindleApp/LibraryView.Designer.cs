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
            uxBookList = new ListBox();
            uxSynchronize = new Button();
            uxOpen = new Button();
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
            // uxBookList
            // 
            uxBookList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uxBookList.Font = new Font("Segoe UI Historic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            uxBookList.FormattingEnabled = true;
            uxBookList.ItemHeight = 28;
            uxBookList.Location = new Point(55, 59);
            uxBookList.Name = "uxBookList";
            uxBookList.Size = new Size(477, 620);
            uxBookList.TabIndex = 1;
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
            uxSynchronize.Click += uxSynchronize_Click;
            // 
            // uxOpen
            // 
            uxOpen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uxOpen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uxOpen.Font = new Font("Segoe UI Historic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            uxOpen.Location = new Point(222, 725);
            uxOpen.Name = "uxOpen";
            uxOpen.Size = new Size(136, 34);
            uxOpen.TabIndex = 3;
            uxOpen.Text = "Open";
            uxOpen.TextAlign = ContentAlignment.TopCenter;
            uxOpen.UseVisualStyleBackColor = true;
            uxOpen.Click += uxOpen_Click;
            // 
            // LibraryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 861);
            Controls.Add(uxOpen);
            Controls.Add(uxSynchronize);
            Controls.Add(uxBookList);
            Controls.Add(uxName);
            Name = "LibraryView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookView";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label uxName;
        #endregion

        private ListBox uxBookList;
        private Button uxSynchronize;
        private Button uxOpen;
    }
}