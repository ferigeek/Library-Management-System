using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Exceptions;

namespace LMS
{
    internal class Import
    {
        private string path { get; set; }

        public Import (string path)
        {
            this.path = path;
        }



        public void ImportExcel()
        {
            using (var workBook = new XLWorkbook(@$"{this.path}"))
            {
                ImportMember(workBook);
                ImportBook(workBook);
                ImportHistory(workBook);
            }
        }

        private void ImportMember (XLWorkbook xLWorkbook)
        {
            var workSheet = xLWorkbook.Worksheet(1);

            using (var workBook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var memberSheet = workBook.Worksheet(1);
                for (int i = 1; i <= workSheet.LastRowUsed().RowNumber(); i++)
                {
                    try
                    {
                        CheckEquality(xLWorkbook, 1, i, "Member");
                    }
                    catch (ImportException ex)
                    {
                        ex.ShowErrorMessage();
                        continue;
                    }


                    int row = memberSheet.LastRowUsed().RowNumber();
                    memberSheet.Cell(row, 1).Value = workSheet.Cell(i, 1).GetValue<string>();
                    memberSheet.Cell(row, 2).Value = workSheet.Cell(i, 2).GetValue<string>();
                    memberSheet.Cell(row, 3).Value = workSheet.Cell(i, 3).GetValue<string>();
                    memberSheet.Cell(row, 4).Value = workSheet.Cell(i, 4).GetValue<string>();
                    memberSheet.Cell(row, 5).Value = workSheet.Cell(i, 5).GetValue<string>();
                    memberSheet.Cell(row, 6).Value = workSheet.Cell(i, 6).GetValue<string>();
                }

                workBook.Save();
            }
        }

        private void ImportBook (XLWorkbook xLWorkbook)
        {
            var workSheet = xLWorkbook.Worksheet(2);

            using (var workBook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var bookSheet = workBook.Worksheet(2);
                for (int i = 1; i <= workSheet.LastRowUsed().RowNumber(); i++)
                {
                    try
                    {
                        CheckEquality(xLWorkbook, 2, i, "Book");
                    }
                    catch (ImportException ex)
                    {
                        ex.ShowErrorMessage();
                        continue;
                    }


                    int row = bookSheet.LastRowUsed().RowNumber();
                    bookSheet.Cell(row, 1).Value = workSheet.Cell(i, 1).GetValue<string>();
                    bookSheet.Cell(row, 2).Value = workSheet.Cell(i, 2).GetValue<string>();
                    bookSheet.Cell(row, 3).Value = workSheet.Cell(i, 3).GetValue<string>();
                    bookSheet.Cell(row, 4).Value = workSheet.Cell(i, 4).GetValue<string>();
                    bookSheet.Cell(row, 5).Value = workSheet.Cell(i, 5).GetValue<string>();
                }

                workBook.Save();
            }
        }

        private void ImportHistory (XLWorkbook xLWorkbook)
        {
            var workSheet = xLWorkbook.Worksheet(3);

            using (var workBook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var historySheet = workBook.Worksheet(3);
                for (int i = 1; i <= workSheet.LastRowUsed().RowNumber(); i++)
                {
                    try
                    {
                        CheckEquality(xLWorkbook, 1, i, "Member");
                    }
                    catch (ImportException ex)
                    {
                        ex.ShowErrorMessage();
                        continue;
                    }


                    int row = historySheet.LastRowUsed().RowNumber();
                    historySheet.Cell(row, 1).Value = workSheet.Cell(i, 1).GetValue<string>();
                    historySheet.Cell(row, 2).Value = workSheet.Cell(i, 2).GetValue<string>();
                    historySheet.Cell(row, 3).Value = workSheet.Cell(i, 3).GetValue<string>();
                }

                workBook.Save();
            }
        }

        private void CheckEquality (XLWorkbook xLWorkbook, int sheetNumber, int row, string type)
        {
            var workSheet = xLWorkbook.Worksheet(sheetNumber);


            using (var mainWorkbook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var mainWorksheet = mainWorkbook.Worksheet(sheetNumber);

                for (int i = 1; i <= mainWorksheet.LastRowUsed().RowNumber(); i++)
                {
                    if (workSheet.Cell(row, 1).GetValue<string>() == mainWorksheet.Cell(i, 1).GetValue<string>())
                    {
                        throw new ImportException("", "", type, row);
                    }
                }
            }
        }
    }
}
