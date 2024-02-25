using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleApp
{
    internal class Controller
    {
        private Model model = new();


        public string UpdatePage(int id, int pageNum)
        {
            return model.MyLibrary[id].BookPages[pageNum];
        }
    }
}
