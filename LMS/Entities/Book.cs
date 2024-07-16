using LMS.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

namespace LMS.Entities
{
    internal class Book
    {
        public Book( int code, string title, string author, string genre )
        {
            Title = title;
            Code = code;
            Author = author;
            Genre = genre;
        }


        /// <summary>
        /// The properties
        /// </summary>


        public string Title { get; set; }
        public int Code { get; set; }

        public string Author { get; set; }
        public string Genre { get; set; }


        ///<summary>
        /// The Methods
        ///</summary>

        public static List<Book> ViewList()
        {
            var result = new List<Book>();

            using (var workbook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var memberSheet = workbook.Worksheet(2);
                if (!memberSheet.IsEmpty())
                {
                    for (int i = 1; i <= memberSheet.LastRowUsed().RowNumber(); i++)
                    {
                        int code = (int)memberSheet.Cell(i, 1).Value;
                        string title = (string)memberSheet.Cell(i, 2).Value;
                        string author = (string)memberSheet.Cell(i, 3).Value;
                        string genre = (string)memberSheet.Cell(i, 4).Value;

                        var book = new Book(code, title, author, genre);

                        result.Add(book);
                    }
                }

                return result;
            }
        }


        private void PutMemberInRow(int row, XLWorkbook workbook)
        {
            var bookSheet = workbook.Worksheet(2);

            bookSheet.Cell(row, 1).Value = Code;
            bookSheet.Cell(row, 2).Value = Title;
            bookSheet.Cell(row, 3).Value = Author;
            bookSheet.Cell(row, 4).Value = Genre;
        }


        public void EditInfoInExcel(int preCode)
        {
            using (var workbook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var bookSheet = workbook.Worksheet(2);
                if (!bookSheet.IsEmpty())
                {
                    for (int i = 1; i <= bookSheet.LastRowUsed().RowNumber(); i++)
                    {
                        if ((int)bookSheet.Cell(i, 1).Value == preCode)
                        {
                            PutMemberInRow(i, workbook);

                            workbook.Save();

                            return;
                        }
                    }
                }
            }
        }


        public static void DeletionInExcel(int code)
        {
            using (var workbook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var memberSheet = workbook.Worksheet(2);
                if (!memberSheet.IsEmpty())
                {
                    for (int i = 1; i <= memberSheet.LastRowUsed().RowNumber(); i++)
                    {
                        if (memberSheet.Cell(i, 1).GetValue<int>() == code)
                        {
                            memberSheet.Row(i).Delete();
                            workbook.Save();
                            return;
                        }
                    }
                }
            }
        }


        public void AddMemberToExcel()
        {
            int row;
            using (var workbook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var memberSheet = workbook.Worksheet(2);

                if (!memberSheet.IsEmpty())
                {
                    row = memberSheet.LastRowUsed().RowNumber() + 1;
                }
                else
                {
                    row = 1;
                }
                PutMemberInRow(row, workbook);
                workbook.Save();
            }
        }


        public override string ToString()
        {
            return $"{this.Code,-10}\t{this.Title,-30}\t{this.Author,-30}";
        }
    }
}
