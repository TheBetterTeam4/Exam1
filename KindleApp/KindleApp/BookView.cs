using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindleApp
{
    public partial class BookView : Form
    {

        private GoToDEL goToPageDel;

        private int BookId;
        private int LastPage;

        public BookView(GoToDEL goToPageDel, int id, int lp, string bookName)
        {
            InitializeComponent();
            this.goToPageDel = goToPageDel;
            this.BookId = id;
            this.LastPage = lp;
            uxName.Text = bookName;

            UpdateView(goToPageDel(BookId, LastPage));
        }

        private void uxNextPage_Click(object sender, EventArgs e)
        {
            string s = goToPageDel(BookId, LastPage + 1);
            if (s != "The End")
            {
                LastPage += 1;
            }
            UpdateView(s);
        }

        private void uxPrevPage_Click(object sender, EventArgs e)
        {
            if (LastPage > 0)
            {
                LastPage -= 1;
                UpdateView(goToPageDel(BookId, LastPage));
            }
        }

        private void UpdateView(string text)
        {
            uxPageText.Text = text;
            uxPageNum.Text = "Page " + (LastPage + 1);
        }
    }
}
