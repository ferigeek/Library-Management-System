using LMS.Forms;
using LMS.Entities;
using ClosedXML;
using ClosedXML.Excel;
using System.Windows.Forms;

namespace LMS
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowMemberList();
            ShowBookList();
            ShowRankList();
            ShowHistoryList();
        }

        public void ShowRankList()
        {
            rankList.Items.Clear();
            rankList.Items.Add($"{"Score",-6}\t{"First Name",-20}\t{"Last Name",-20}");
            rankList.Items.Add(String.Empty);
            var ScoreList =
                from member in Member.ViewList()
                orderby member.Score descending
                select member;
            foreach (var member in ScoreList)
            {
                rankList.Items.Add($"{member.Score,-6}\t{member.FirstName,-20}\t{member.LastName,-20}");
            }
        }

        public void ShowMemberList()
        {
            memberList.Items.Clear();
            memberList.Items.Add($"{"ID",-10}\t{"First Name",-25}\t{"Last Name",-25}");
            memberList.Items.Add(String.Empty);
            var members = Member.ViewList();
            foreach (var member in members)
            {
                memberList.Items.Add(member);
            }
        }

        public void ShowBookList()
        {
            bookList.Items.Clear();
            bookList.Items.Add($"{"Code",-10}\t{"Title",-40}\t{"Author",-30}");
            bookList.Items.Add(String.Empty);
            var books = Book.ViewList();
            foreach (var book in books)
            {
                bookList.Items.Add(book);
            }
        }

        public void ShowHistoryList()
        {
            DeadLineList.Items.Clear();
            DeadLineList.Items.Add($"{"Date",-20}\t{"Book Code",-20}\t{"Member ID",-20}");
            DeadLineList.Items.Add(String.Empty);

            var collection =
                from history in History.ViewList()
                orderby history.year, history.month, history.day
                select history;

            foreach (var h in collection)
            {
                string s = h.year + "-" + h.month + "-" + h.day;

                DeadLineList.Items.Add($"{s,-20}\t{h.bookCode,-20}\t{h.memberID,-20}");
            }
        }

        private void ViewMemberBtn_Click(object sender, EventArgs e)
        {
            if (memberList.SelectedItem == null)
            {
                MessageBox.Show("You didn't choose any item from the list!", "Choose an Item", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            else if (memberList.SelectedItem.Equals(memberList.Items[0]) ||
                memberList.SelectedItem.Equals(memberList.Items[1]))
            {
                return;
            }
            else
            {
                var selected = memberList.SelectedItem.ToString();

                var split = selected.Split(' ')[0];
                var id = Convert.ToInt32(split);

                MemberView infoForm = new MemberView(id, this);
                infoForm.ShowDialog();
            }
        }

        private void DeleteMemberBtn_Click(object sender, EventArgs e)
        {
            if (memberList.SelectedItem == null)
            {
                MessageBox.Show("You didn't choose any item from the list!", "Choose an Item", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            else if (memberList.SelectedItem.Equals(memberList.Items[0]) ||
                memberList.SelectedItem.Equals(memberList.Items[1]))
            {
                return;
            }
            else
            {
                int idPass = Convert.ToInt32(memberList.SelectedItem.ToString().Split(' ')[0]);

                Member.DeletionInExcel(idPass);

                MessageBox.Show("Member has been successfully deleted!", "Operation Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowMemberList();
                ShowRankList();
            }
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            var AddMemberWindow = new MemberAddition(this);

            AddMemberWindow.ShowDialog();
        }

        private void ViewBookBtn_Click(object sender, EventArgs e)
        {
            if (bookList.SelectedItem == null)
            {
                MessageBox.Show("You didn't choose any item from the list!", "Choose an Item", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            else if (bookList.SelectedItem.Equals(bookList.Items[0]) ||
                bookList.SelectedItem.Equals(bookList.Items[1]))
            {
                return;
            }
            else
            {
                var selected = bookList.SelectedItem.ToString();

                var split = selected.Split(' ')[0];
                var code = Convert.ToInt32(split);

                BookView infoForm = new BookView(code, this);
                infoForm.ShowDialog();
            }
        }

        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {
            if (bookList.SelectedItem == null)
            {
                MessageBox.Show("You didn't choose any item from the list!", "Choose an Item", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            else if (bookList.SelectedItem.Equals(bookList.Items[0]) ||
                bookList.SelectedItem.Equals(bookList.Items[1]))
            {
                return;
            }
            else
            {
                int codePass = Convert.ToInt32(bookList.SelectedItem.ToString().Split(' ')[0]);

                Book.DeletionInExcel(codePass);

                MessageBox.Show("Member has been successfully deleted!", "Operation Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowBookList();
                ShowMemberList();
                ShowRankList();
            }
        }

        private void memberList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var member = memberList.SelectedItem.ToString().Split()[0];

            using (var workBook = new XLWorkbook(@"LMS.xlsx"))
            {
                var memberSheet = workBook.Worksheet(1);
                for (int i = 1; i <= memberSheet.LastRowUsed().RowNumber(); i++)
                {
                    if (memberSheet.Cell(i, 1).GetValue<string>() == member)
                    {
                        string s = memberSheet.Cell(i, 1).GetValue<string>();
                        s += '\t';
                        s += memberSheet.Cell(i, 2).GetValue<string>();
                        s += '\t';
                        s += memberSheet.Cell(i, 3).GetValue<string>();

                        MemberSelectText.Text = s;
                    }
                }
            }
        }

        private void bookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var book = bookList.SelectedItem.ToString().Split()[0];

            using (var workBook = new XLWorkbook(@"LMS.xlsx"))
            {
                var bookSheet = workBook.Worksheet(2);
                for (int i = 1; i <= bookSheet.LastRowUsed().RowNumber(); i++)
                {
                    if (bookSheet.Cell(i, 1).GetValue<string>() == book)
                    {
                        string s = bookSheet.Cell(i, 1).GetValue<string>();
                        s += '\t';
                        s += bookSheet.Cell(i, 2).GetValue<string>();
                        s += '\t';
                        s += bookSheet.Cell(i, 3).GetValue<string>();

                        BookSelectText.Text = s;

                        return;
                    }
                }
            }
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            var addingWindow = new BookAddition(this);

            addingWindow.ShowDialog();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LendBtn_Click(object sender, EventArgs e)
        {
            PrimaryLendRetrievePanel.Enabled = false;
            PrimaryLendRetrievePanel.Visible = false;

            LendingInputPanel.Enabled = true;
            LendingInputPanel.Visible = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            LendingInputPanel.Enabled = false;
            LendingInputPanel.Visible = false;

            PrimaryLendRetrievePanel.Enabled = true;
            PrimaryLendRetrievePanel.Visible = true;
        }

        private void LendApplyBtn_Click(object sender, EventArgs e)
        {
            var memberID = MemberSelectText.Text.Split()[0];
            var bookCode = BookSelectText.Text.Split()[0];
            var year = dateTimePicker1.Value.Year;
            var month = dateTimePicker1.Value.Month;
            var day = dateTimePicker1.Value.Day;

            var lend = new History(Convert.ToInt32(bookCode), Convert.ToInt32(memberID), year, month, day);

            lend.Lend();

            LendingInputPanel.Enabled = false;
            LendingInputPanel.Visible = false;

            PrimaryLendRetrievePanel.Enabled = true;
            PrimaryLendRetrievePanel.Visible = true;

            ShowHistoryList();
        }

        private void DeadLineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeadLineList.SelectedItem.Equals(DeadLineList.Items[0]) ||
                DeadLineList.SelectedItem.Equals(DeadLineList.Items[1]) ||
                DeadLineList.SelectedItem == null)
            {
                return;
            }

            var dead = DeadLineList.SelectedItem.ToString();
            var deadS = dead.Split();

            string d = "";
            string c = "";
            string i = "";

            int cc = 1;

            foreach (var item in deadS)
            {
                if (item != "")
                {
                    if (cc == 1)
                        d = item;
                    else if (cc == 2)
                        c = item;
                    else
                        i = item;
                    cc++;
                }
            }

            deadlineText.Text = c;
        }

        private void RetrieveBtn_Click(object sender, EventArgs e)
        {
            PrimaryLendRetrievePanel.Enabled = false;
            PrimaryLendRetrievePanel.Visible = false;

            retrievePanel.Enabled = true;
            retrievePanel.Visible = true;
        }

        private void Cancel2Btn_Click(object sender, EventArgs e)
        {
            retrievePanel.Enabled = false;
            retrievePanel.Visible = false;

            PrimaryLendRetrievePanel.Enabled = true;
            PrimaryLendRetrievePanel.Visible = true;
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            string code = deadlineText.Text;
            string id = "";
            string date = "";


            using (var workBook = new XLWorkbook(@"./LMS.xlsx"))
            {
                var lendSheet = workBook.Worksheet(3);

                if (!lendSheet.IsEmpty())
                {
                    for (int i = 1; i <= lendSheet.LastRowUsed().RowNumber(); i++)
                    {
                        if (lendSheet.Cell(i, 1).GetValue<string>() == code)
                        {
                            id = lendSheet.Cell(i, 2).GetValue<string>();
                            date = lendSheet.Cell(i, 3).GetValue<string>();
                            lendSheet.Row(i).Delete();
                            break;
                        }
                    }
                }



                var bookSheet = workBook.Worksheet(2);
                if (!bookSheet.IsEmpty())
                {
                    for (int i = 1; i <= bookSheet.LastRowUsed().RowNumber(); i++)
                    {
                        if (bookSheet.Cell(i, 5).GetValue<string>() == id)
                        {
                            bookSheet.Cell(i, 5).Clear();
                            break;
                        }
                    }
                }



                DateTime today = DateTime.Now.Date;
                var memberSheet = workBook.Worksheet(1);
                if (!memberSheet.IsEmpty())
                {
                    for (int i = 1; i <= memberSheet.LastRowUsed().RowNumber(); i++)
                    {
                        if (memberSheet.Cell(i, 1).GetValue<string>() == id)
                        {
                            string s = memberSheet.Cell(i, 6).GetValue<string>();
                            var split = s.Split(',');

                            s = "";

                            foreach (var c in split)
                            {
                                if (c.Trim() == code || c == "")
                                    continue;
                                else
                                {
                                    s += c.Trim() + ", ";
                                }
                            }

                            //Giving score accroding to how soon the book has been retrieved.

                            memberSheet.Cell(i, 6).Value = s;

                            int year = Convert.ToInt32(date.Split('/')[0]);
                            int month = Convert.ToInt32(date.Split('/')[1]);
                            int day = Convert.ToInt32(date.Split('/')[2]);

                            int score = memberSheet.Cell(i, 5).GetValue<int>();
                            score += (year - today.Year) * 365;
                            score += (month - today.Month) * 30;
                            score += (day - today.Day);

                            memberSheet.Cell(i, 5).Value = score;

                            break;
                        }
                    }
                }

                workBook.Save();
            }

            ShowHistoryList();
            retrievePanel.Enabled = false;
            retrievePanel.Visible = false;

            PrimaryLendRetrievePanel.Enabled = true;
            PrimaryLendRetrievePanel.Visible = true;
        }

        private void ExcelExport_Click(object sender, EventArgs e)
        {
            ExcelExportSave.Filter = "Excel Files (*.xlsx)|*.xlsx";
            ExcelExportSave.Title = "Export app's excel file";
            ExcelExportSave.FileName = "LibraryManagementSystem.xlsx";


            if (ExcelExportSave.ShowDialog() == DialogResult.OK)
            {
                string destinationFilePath = ExcelExportSave.FileName;

                try
                {
                    File.Copy(@"./LMS.xlsx", destinationFilePath, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "Select an Excel File";
            openFileDialog.FileName = "";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    using (var workBook = new XLWorkbook(filePath))
                    {
                        var workSheet = workBook.Worksheet(1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var import = new Import(filePath);
                import.ImportExcel();
            }


            ShowMemberList();
            ShowBookList();
            ShowHistoryList();
            ShowRankList();
        }
    }
}
