using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Exceptions;

namespace LMS.Entities
{
    public class History
    {
        public History ( int bookCode, int memberID, int year, int month, int day)
        {
            this.bookCode = bookCode;
            this.memberID = memberID;
            this.year = year;
            this.month = month;
            this.day = day;
        }


        /// <summary>
        /// Properties
        /// </summary>

        public int bookCode {  get; set; }
        public int memberID { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }

        /// <summary>
        /// Methods
        /// </summary>
        /// 



        public static List<History> ViewList()
        {

            var result = new List<History>();

            using (var workBook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var lendSheet = workBook.Worksheet(3);

                if (!lendSheet.IsEmpty())
                {
                    for (int i = 1; i <= lendSheet.LastRowUsed().RowNumber(); i++)
                    {
                        int bookCode = lendSheet.Cell(i, 1).GetValue<int>();
                        int memberID = lendSheet.Cell(i, 2).GetValue<int>();
                        string date = lendSheet.Cell(i, 3).GetValue<string>();

                        var dateSplit = date.Split('/');

                        int year = int.Parse(dateSplit[0]);
                        int month = int.Parse(dateSplit[1]);
                        int day = int.Parse(dateSplit[2]);

                        var l = new History(bookCode, memberID, year, month, day);

                        result.Add(l);
                    }
                }
            }

            return result;
        }


        public void Lend()
        {
            using (var workBook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var lendSheet = workBook.Worksheet(3);
                int row;
                try
                {
                    if (!lendSheet.IsEmpty())
                    {
                        row = lendSheet.LastRowUsed().RowNumber() + 1;
                        for (int i = 1; i <= lendSheet.LastRowUsed().RowNumber(); i++)
                        {
                            if (lendSheet.Cell(i, 1).GetValue<int>() ==  bookCode)
                            {
                                throw new LendingException();
                                break;
                            }
                        }
                    }
                    else
                    {
                        row = 1;
                    }
                }
                catch (LendingException ex)
                {
                    ex.ShowErrorMessage();
                    return;
                }

                lendSheet.Cell(row, 1).Value = bookCode;
                lendSheet.Cell(row, 2).Value = memberID;
                lendSheet.Cell(row, 3).Value = $"{year}/{month}/{day}";

                var bookSheet = workBook.Worksheet(2);

                for (int i = 1; i <= bookSheet.LastRowUsed().RowNumber(); i++)
                {
                    if (bookSheet.Cell(i, 1).GetValue<int>() == bookCode)
                    {
                        bookSheet.Cell(i, 5).Value = memberID;
                    }
                }

                var memberSheet = workBook.Worksheet(1);

                for (int i = 1; i <= memberSheet.LastRowUsed().RowNumber(); i++)
                {
                    if (memberSheet.Cell(i, 1).GetValue<int>() ==  memberID)
                    {
                        string s = memberSheet.Cell(i, 6).GetValue<string>();
                        s += $", {bookCode}";
                        memberSheet.Cell(i, 6).Value = s;
                    }
                }

                workBook.Save();
            }
        }
    }
}
