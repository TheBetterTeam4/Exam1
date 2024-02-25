using System.Runtime.CompilerServices;

namespace KindleApp
{

    public delegate void OpenBookDEL(int id);
    public delegate List<Book> SyncDEL();
    public delegate string GoToDEL(int id, int pageNum);


    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Controller c = new();
            //TODO: Erase this, left for testing BookView
            //Application.Run(new BookView(c.UpdatePageText, 0, 0));
            Application.Run(new LibraryView(c.OpenBook, c.SyncList));
        }
    }
}