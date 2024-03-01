using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleApp
{
    public class Controller
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
            BookView book = new(UpdatePageText, id, lp, model.MyLibrary[id].BookName, AddRemoveMark, ReturnMarks);
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

        public void AddRemoveMark(int bookId, bool addOrRemove, int pageNum)
        {
            Bookmark mark = new(pageNum);
            if (addOrRemove && model.MyLibrary[bookId].BookMarks.Count <= 5)
            {
                model.MyLibrary[bookId].BookMarks.Add(mark);

            }
            else if (!addOrRemove)
            {
                List<Bookmark> newList = new();
                foreach(var item in model.MyLibrary[bookId].BookMarks)
                {
                    if (item.PageNum != mark.PageNum)
                    {
                        newList.Add(item);
                    }
                }
                model.MyLibrary[bookId].BookMarks = newList;
            }
        }

        private List<Bookmark> ReturnMarks(int bookId)
        {
            return model.MyLibrary[bookId].BookMarks;
        }
    }
}
