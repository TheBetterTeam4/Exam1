using System.Windows.Forms;

namespace KindleApp
{
    public partial class LibraryView : Form
    {
        private OpenBookDEL openBookDel;
        private SyncDEL SyncDel;

        public LibraryView(OpenBookDEL openBookDel, SyncDEL SyncDel)
        {
            InitializeComponent();
            this.openBookDel = openBookDel;
            this.SyncDel = SyncDel;
        }

        private void uxSynchronize_Click(object sender, EventArgs e)
        {
            List<Book> lib = SyncDel();

            UxBookList.Items.Clear();

            foreach (var item in lib)
            {
                UxBookList.Items.Add(item.BookName);
            }
            
        }

        private void uxOpen_Click(object sender, EventArgs e)
        {
            openBookDel(UxBookList.SelectedIndex);
        }

        
    }
}