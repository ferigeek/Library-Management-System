using LMS.Forms;
using LMS.Entities;
using ClosedXML;

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

        }

        private void bookList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            var addingWindow = new BookAddition(this);

            addingWindow.ShowDialog();
        }
    }
}
