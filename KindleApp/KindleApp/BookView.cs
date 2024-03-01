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
        private BookMarkDEL BookMarkDel;
        private GoToDEL goToPageDel;
        private OpenBookDEL OpenBookDel;
        private ReturnMarksDEL ReturnMarksDel;

        private int bookId;
        private int lastPage;
        private List<Bookmark> bookMarks;

        public BookView(GoToDEL goToPageDel, int id, int lp, string bookName, BookMarkDEL bookMarkDel, ReturnMarksDEL returnMarksDel)
        {
            InitializeComponent();
            this.goToPageDel = goToPageDel;
            this.BookMarkDel = bookMarkDel;
            this.ReturnMarksDel = returnMarksDel;
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

            //Bookmarks algorithm
            bookMarks = ReturnMarksDel(bookId);

            uxMark1.Visible = false;
            uxMark2.Visible = false;
            uxMark3.Visible = false;
            uxMark4.Visible = false;
            uxMark5.Visible = false;

            if (bookMarks.Count > 0)
            {
                uxMark1.Text = "" + (bookMarks[0].PageNum+1);
                uxMark1.Visible = true;
            }
            if (bookMarks.Count > 1)
            {
                uxMark2.Text = "" + (bookMarks[1].PageNum+1);
                uxMark2.Visible = true;
            }
            if (bookMarks.Count > 2)
            {
                uxMark3.Text = "" + (bookMarks[2].PageNum+1);
                uxMark3.Visible = true;
            }
            if (bookMarks.Count > 3)
            {
                uxMark4.Text = "" + (bookMarks[3].PageNum+1);
                uxMark4.Visible = true;
            }
            if (bookMarks.Count > 4)
            {
                uxMark5.Text = "" + (bookMarks[4].PageNum+1);
                uxMark5.Visible = true;
            }
        }

        #region BookMark_Click
        private void uxMark1_Click(object sender, EventArgs e)
        {
            int pageNum = Convert.ToInt32(uxMark1.Text)-1;
            MarkClickHandler(pageNum);
        }

        private void uxMark2_Click(object sender, EventArgs e)
        {
            int pageNum = Convert.ToInt32(uxMark2.Text)-1;
            MarkClickHandler(pageNum);
        }

        private void uxMark3_Click(object sender, EventArgs e)
        {
            int pageNum = Convert.ToInt32(uxMark3.Text)-1;
            MarkClickHandler(pageNum);
        }

        private void uxMark4_Click(object sender, EventArgs e)
        {
            int pageNum = Convert.ToInt32(uxMark4.Text)-1;
            MarkClickHandler(pageNum);
        }

        private void uxMark5_Click(object sender, EventArgs e)
        {
            int pageNum = Convert.ToInt32(uxMark5.Text)-1;
            MarkClickHandler(pageNum);
        }
        #endregion

        private void MarkClickHandler(int page)
        {
            lastPage = page;
            UpdateView(goToPageDel(bookId, page));
        }

        private void uxAddMark_Click(object sender, EventArgs e)
        {
            BookMarkDel(bookId, true, lastPage);
            UpdateView(goToPageDel(bookId, lastPage));
        }

        private void uxRemoveMark_Click(object sender, EventArgs e)
        {
            BookMarkDel(bookId, false, lastPage);
            UpdateView(goToPageDel(bookId, lastPage));
        }
    }
}
