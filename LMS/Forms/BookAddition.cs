using LMS.Exceptions;
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
    public partial class BookAddition : Form
    {
        public BookAddition(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private MainWindow mainWindow;

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int code;

            try
            {
                bool b = int.TryParse(CodeText.Text, out code);
                if (!b)
                {
                    throw new InvalidInputCode();
                }
            }

            catch (InvalidInputCode ex)
            {
                ex.ShowErrorMessage();
                return;
            }


            var newBook = new Book(code, TitleText.Text, AuthorText.Text, GenreText.Text);

            newBook.AddMemberToExcel();

            mainWindow.ShowBookList();

            this.Close();
        }
    }
}
