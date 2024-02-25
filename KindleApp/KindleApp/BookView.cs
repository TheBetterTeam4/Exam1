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


        public BookView(GoToDEL goToPageDel, int id, int lp)
        {
            InitializeComponent();
            this.goToPageDel = goToPageDel;
            this.BookId = id;
            this.LastPage = lp;

            UpdateView(goToPageDel(BookId, LastPage), LastPage);
        }

        private void uxNextPage_Click(object sender, EventArgs e)
        {
            string s = goToPageDel(BookId, LastPage + 1);
            if (s != "The End")
            {
                LastPage += 1;
            }
            UpdateView(s, LastPage);
        }

        private void uxPrevPage_Click(object sender, EventArgs e)
        {
            if (LastPage > 0)
            {
                LastPage -= 1;
                UpdateView(goToPageDel(BookId, LastPage - 1), LastPage);
            }
        }

        private void UpdateView(string text, int page)
        {
            uxPageText.Text = text;
            uxPageNum.Text = "Page " + page;
        }
    }
}
