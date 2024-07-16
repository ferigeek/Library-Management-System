using ClosedXML.Excel;

namespace LMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            if (!File.Exists(@"./LMS.xlsx"))
            {
                using ( var workbook = new XLWorkbook() )
                {
                    var Members = workbook.Worksheets.Add("Members");
                    var Books = workbook.Worksheets.Add("Books");
                    workbook.SaveAs(@"./LMS.xlsx");
                }
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}