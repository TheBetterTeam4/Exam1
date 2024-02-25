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

        private int bookId;
        private int lastPage;

        public BookView(GoToDEL goToPageDel, int id, int lp, string bookName)
        {
            InitializeComponent();
            this.goToPageDel = goToPageDel;
            this.bookId = id;
            this.lastPage = lp;
            uxName.Text = bookName;

            UpdateView(goToPageDel(bookId, lastPage));
        }

        private void uxNextPage_Click(object sender, EventArgs e)
        {
            string s = goToPageDel(bookId, lastPage + 1);
            if (s != "The End")
            {
                lastPage += 1;
            }
            UpdateView(s);
        }

        private void uxPrevPage_Click(object sender, EventArgs e)
        {
            if (lastPage > 0)
            {
                lastPage -= 1;
                UpdateView(goToPageDel(bookId, lastPage));
            }
        }

        private void UpdateView(string text)
        {
            uxPageText.Text = text;
            uxPageNum.Text = "Page " + (lastPage + 1);
        }
    }
}
