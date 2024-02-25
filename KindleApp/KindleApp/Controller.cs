using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleApp
{
    internal class Controller
    {
        private Model model = new Model();

        public string UpdatePageText(int id, int pageNum)
        {
            if (pageNum == model.MyLibrary[id].BookPages.Count())
            {
                return "The End";
            }
            model.MyLibrary[id].LastPage = pageNum;
            return model.MyLibrary[id].BookPages[pageNum];
        }

        public void OpenBook(int id)
        {
            int lp = model.MyLibrary[id].LastPage;
            BookView book = new(UpdatePageText, id, lp, model.MyLibrary[id].BookName);
            book.ShowDialog();
        }

        public List<Book> SyncList()
        {
            List<Book> ret = new();

            foreach (var item in model.MyLibrary.Values)
            {
                ret.Add(item);
            }

            return ret;
        }
    }
}
