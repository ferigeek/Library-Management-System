using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using LMS.Exceptions;

namespace LMS.Entities
{
    internal class Member
    {
        public Member ( int id, string firstName,  string lastName, string membershipType, int score )
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            MembershipType = membershipType;
            Score = score;
        }


        /// <summary>
        /// Properties
        /// </summary>
        

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MembershipType { get; set; }
        public int Score { get; set; }


        /// <summary>
        /// Methods
        /// </summary>
        

        public static List<Member> ViewList ()
        {
            var result = new List<Member> ();

            using (var workbook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var memberSheet = workbook.Worksheet(1);
                if (!memberSheet.IsEmpty())
                {
                    for (int i = 1; i <= memberSheet.LastRowUsed().RowNumber(); i++)
                    {
                        int id = (int)memberSheet.Cell(i, 1).Value;
                        string firstName = (string)memberSheet.Cell(i, 2).Value;
                        string lastName = (string)memberSheet.Cell(i, 3).Value;
                        string membershipType = (string)memberSheet.Cell(i, 4).Value;
                        int score = (int)memberSheet.Cell(i, 5).Value;

                        var member = new Member(id, firstName, lastName, membershipType, score);

                        result.Add(member);
                    }
                }

                return result;
            }
        }

        private void PutMemberInRow(int row, XLWorkbook workbook)
        {
            var memberSheet = workbook.Worksheet(1);

            memberSheet.Cell(row, 1).Value = ID;
            memberSheet.Cell(row, 2).Value = FirstName;
            memberSheet.Cell(row, 3).Value = LastName;
            memberSheet.Cell(row, 4).Value = MembershipType;
            memberSheet.Cell(row, 5).Value = Score;
        }


        public void EditInfoInExcel(int preID)
        {
            using (var workbook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var memberSheet = workbook.Worksheet(1);
                if (!memberSheet.IsEmpty())
                {
                    for (int i = 1; i <= memberSheet.LastRowUsed().RowNumber(); i++)
                    {
                        if ((int)memberSheet.Cell(i, 1).Value == preID)
                        {
                            PutMemberInRow(i, workbook);

                            workbook.Save();

                            return;
                        }
                    }
                }
            }
        }

        public static void DeletionInExcel (int id)
        {
            using (var workbook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var memberSheet = workbook.Worksheet(1);
                if (!memberSheet.IsEmpty())
                {
                    for (int i = 1; i <= memberSheet.LastRowUsed().RowNumber(); i++)
                    {
                        if (memberSheet.Cell(i, 1).GetValue<int>() == id)
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
                var memberSheet = workbook.Worksheet(1);

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
            return $"{this.ID,-10}\t{this.FirstName,-25}\t{this.LastName,-25}";
        }
    }
}
