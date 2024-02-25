namespace KindleApp
{

    public delegate void OpenBookDEL(int id);
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

            Application.Run(new BookView(c.UpdatePage));
        }
    }
}