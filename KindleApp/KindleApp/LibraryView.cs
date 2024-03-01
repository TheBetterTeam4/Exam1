using System.Windows.Forms;

namespace KindleApp
{
    public partial class LibraryView : Form
    {
        private OpenBookDEL OpenBookDel;
        private SyncDEL SyncDel;

        public LibraryView(OpenBookDEL openBookDel, SyncDEL SyncDel)
        {
            InitializeComponent();
            this.OpenBookDel = openBookDel;
            this.SyncDel = SyncDel;
        }

        private void uxSynchronize_Click(object sender, EventArgs e)
        {
            List<Book> lib = SyncDel();

            uxBookList.Items.Clear();

            foreach (var item in lib)
            {
                uxBookList.Items.Add(item.BookName);
            }

        }

        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxBookList.SelectedIndex != -1)
            {
                OpenBookDel(uxBookList.SelectedIndex);
            }
        }
    }
}