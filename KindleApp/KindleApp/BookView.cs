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

        public GoToDEL goToPageDel;

        public int BookId = 0;
        public int LastPage = 0;


        public BookView(GoToDEL goToPageDel)
        {
            InitializeComponent();
            this.goToPageDel = goToPageDel;

            uxPageText.Text = goToPageDel(BookId, LastPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uxPageText.Text = goToPageDel(BookId, LastPage + 1);

        }
    }
}
