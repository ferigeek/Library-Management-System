using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Entities;

namespace LMS.Forms
{
    public partial class MemberView : Form
    {
        public MemberView(int id, MainWindow mainWindow)
        {
            MemberID = id;
            this.mainWindow = mainWindow;
            InitializeComponent();

            using (var workbook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var memberSheet = workbook.Worksheet(1);
                if (!memberSheet.IsEmpty())
                {
                    for (int i = 1; i <= memberSheet.LastRowUsed().RowNumber(); i++)
                    {
                        if ((int)memberSheet.Cell(i, 1).Value == MemberID)
                        {
                            IDText.Text = memberSheet.Cell(i, 1).GetValue<string>();
                            FirstNameText.Text = (string)memberSheet.Cell(i, 2).Value;
                            LastNameText.Text = (string)memberSheet.Cell(i, 3).Value;
                            MembershipText.Text = (string)memberSheet.Cell(i, 4).Value;
                            ScoreText.Text = (string)memberSheet.Cell(i, 5).GetValue<string>();

                            if (!memberSheet.Cell(i, 6).IsEmpty())
                            {
                                var booklist = memberSheet.Cell(i, 6).GetValue<string>();
                                var booklistSplit = booklist.Split(',');
                                var bookSheet = workbook.Worksheet(2);
                                foreach (var book in booklistSplit)
                                {
                                    string bookID = book.Trim();
                                    
                                    for (int j = 1; j <= bookSheet.LastRowUsed().RowNumber(); j++)
                                    {
                                        if (bookSheet.Cell(j, 1).GetValue<string>() == bookID)
                                        {
                                            BorrowedBooksList.Items.Add((string) bookSheet.Cell(j, 2).Value);
                                        }
                                    }
                                }
                            }

                            return;
                        }
                    }
                }
            }
        }

        private int MemberID { get; set; }
        private MainWindow mainWindow { get; set; }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            FirstNameText.ReadOnly = false;
            LastNameText.ReadOnly = false;
            IDText.ReadOnly = false;
            MembershipText.ReadOnly = false;
            ScoreText.ReadOnly = false;
            EditBtn.Enabled = false;
            EditBtn.Visible = false;
            ApplyBtn.Enabled = true;
            ApplyBtn.Visible = true;
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            var member = new LMS.Entities.Member(Convert.ToInt32(IDText.Text.Trim()), FirstNameText.Text.Trim()
                , LastNameText.Text.Trim(), MembershipText.Text, Convert.ToInt32(ScoreText.Text.Trim()));


            member.EditInfoInExcel(MemberID);           

            mainWindow.ShowMemberList();
            mainWindow.ShowRankList();

            this.Close();
        }
    }
}
