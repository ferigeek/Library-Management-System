using ClosedXML.Excel;
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
    public partial class BookView : Form
    {
        public BookView(int code, MainWindow mainWindow)
        {
            this.code = code;
            this.mainWindow = mainWindow;
            InitializeComponent();

            using (var workbook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var bookSheet = workbook.Worksheet(2);
                if (!bookSheet.IsEmpty())
                {
                    for (int i = 1; i <= bookSheet.LastRowUsed().RowNumber(); i++)
                    {
                        if ((int)bookSheet.Cell(i, 1).Value == code)
                        {
                            CodeText.Text = bookSheet.Cell(i, 1).GetValue<string>();
                            TitleText.Text = (string)bookSheet.Cell(i, 2).Value;
                            AuthorText.Text = (string)bookSheet.Cell(i, 3).Value;
                            GenreText.Text = (string)bookSheet.Cell(i, 4).Value;

                            if (bookSheet.Cell(i, 5).IsEmpty())
                            {
                                BorrowedText.Text = "No one";
                            }
                            else
                            {
                                string memberid = bookSheet.Cell(i, 5).GetValue<string>();
                                var memberSheet = workbook.Worksheet(1);
                                for (int j = 1; j <= memberSheet.LastRowUsed().RowNumber(); j++)
                                {
                                    if (memberSheet.Cell(j, 1).GetValue<string>() == memberid)
                                    {
                                        string s = memberSheet.Cell(j, 2).GetValue<string>() + '\t' + memberSheet.Cell(j, 3).GetValue<string>();
                                        BorrowedText.Text = s;
                                    }
                                }

                            }

                            return;
                        }
                    }
                }
            }
        }

        private int code { get; set; }
        private MainWindow mainWindow;

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            TitleText.ReadOnly = false;
            AuthorText.ReadOnly = false;
            CodeText.ReadOnly = false;
            GenreText.ReadOnly = false;

            EditBtn.Visible = false;
            EditBtn.Enabled = false;

            ApplyBtn.Enabled = true;
            ApplyBtn.Visible = true;
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            var book = new Book(Convert.ToInt32(CodeText.Text), TitleText.Text, AuthorText.Text, GenreText.Text);

            book.EditInfoInExcel(code);

            mainWindow.ShowBookList();

            this.Close();
        }
    }
}
