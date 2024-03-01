using System.Runtime.CompilerServices;

namespace KindleApp
{

    public delegate void OpenBookDEL(int id);
    public delegate List<Book> SyncDEL();
    public delegate string GoToDEL(int id, int pageNum);
    public delegate void BookMarkDEL(int bookId, bool addOrRemove, int pageNum);
    public delegate List<Bookmark> ReturnMarksDEL(int id);

    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Controller c = new();
            Application.Run(new LibraryView(c.OpenBook, c.SyncList));
        }
    }
}