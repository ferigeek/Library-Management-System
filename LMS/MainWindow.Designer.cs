namespace LMS
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            MemberPanel = new Panel();
            memberList = new ListBox();
            ViewMemberBtn = new Button();
            MemberLabel = new Label();
            AddMemberBtn = new Button();
            DeleteMemberBtn = new Button();
            BookPanel = new Panel();
            AddBookBtn = new Button();
            ViewBookBtn = new Button();
            bookList = new ListBox();
            BookLabel = new Label();
            DeleteBookBtn = new Button();
            ScorePanel = new Panel();
            rankList = new ListBox();
            RankLabel = new Label();
            HistoryPanel = new Panel();
            DeadLineList = new ListBox();
            DeadLineLabel = new Label();
            PrimaryLendRetrievePanel = new Panel();
            LendBtn = new Button();
            RetrieveBtn = new Button();
            LendingPanel = new Panel();
            retrievePanel = new Panel();
            RetrieveButton = new Button();
            Cancel2Btn = new Button();
            deadlineText = new TextBox();
            Deadline = new Label();
            LendingInputPanel = new Panel();
            LendApplyBtn = new Button();
            CancelBtn = new Button();
            DateLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            LabelBook = new Label();
            BookSelectText = new TextBox();
            MemberSelectText = new TextBox();
            memLabel = new Label();
            LendingLabel = new Label();
            CloseBtn = new Button();
            selectionTip = new ToolTip(components);
            MemberPanel.SuspendLayout();
            BookPanel.SuspendLayout();
            ScorePanel.SuspendLayout();
            HistoryPanel.SuspendLayout();
            PrimaryLendRetrievePanel.SuspendLayout();
            LendingPanel.SuspendLayout();
            retrievePanel.SuspendLayout();
            LendingInputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MemberPanel
            // 
            MemberPanel.BorderStyle = BorderStyle.FixedSingle;
            MemberPanel.Controls.Add(memberList);
            MemberPanel.Controls.Add(ViewMemberBtn);
            MemberPanel.Controls.Add(MemberLabel);
            MemberPanel.Controls.Add(AddMemberBtn);
            MemberPanel.Controls.Add(DeleteMemberBtn);
            MemberPanel.Location = new Point(12, 12);
            MemberPanel.Name = "MemberPanel";
            MemberPanel.Size = new Size(403, 245);
            MemberPanel.TabIndex = 0;
            // 
            // memberList
            // 
            memberList.FormattingEnabled = true;
            memberList.ItemHeight = 15;
            memberList.Location = new Point(3, 18);
            memberList.Name = "memberList";
            memberList.Size = new Size(395, 184);
            memberList.TabIndex = 5;
            memberList.SelectedIndexChanged += memberList_SelectedIndexChanged;
            memberList.DoubleClick += ViewMemberBtn_Click;
            // 
            // ViewMemberBtn
            // 
            ViewMemberBtn.Location = new Point(3, 208);
            ViewMemberBtn.Name = "ViewMemberBtn";
            ViewMemberBtn.Size = new Size(75, 23);
            ViewMemberBtn.TabIndex = 2;
            ViewMemberBtn.Text = "View";
            ViewMemberBtn.UseVisualStyleBackColor = true;
            ViewMemberBtn.Click += ViewMemberBtn_Click;
            // 
            // MemberLabel
            // 
            MemberLabel.AutoSize = true;
            MemberLabel.Location = new Point(3, 0);
            MemberLabel.Name = "MemberLabel";
            MemberLabel.Size = new Size(57, 15);
            MemberLabel.TabIndex = 0;
            MemberLabel.Text = "Members";
            // 
            // AddMemberBtn
            // 
            AddMemberBtn.Location = new Point(84, 208);
            AddMemberBtn.Name = "AddMemberBtn";
            AddMemberBtn.Size = new Size(75, 23);
            AddMemberBtn.TabIndex = 3;
            AddMemberBtn.Text = "Add";
            AddMemberBtn.UseVisualStyleBackColor = true;
            AddMemberBtn.Click += AddMemberBtn_Click;
            // 
            // DeleteMemberBtn
            // 
            DeleteMemberBtn.Location = new Point(165, 208);
            DeleteMemberBtn.Name = "DeleteMemberBtn";
            DeleteMemberBtn.Size = new Size(75, 23);
            DeleteMemberBtn.TabIndex = 4;
            DeleteMemberBtn.Text = "Delete";
            DeleteMemberBtn.UseVisualStyleBackColor = true;
            DeleteMemberBtn.Click += DeleteMemberBtn_Click;
            // 
            // BookPanel
            // 
            BookPanel.BorderStyle = BorderStyle.FixedSingle;
            BookPanel.Controls.Add(AddBookBtn);
            BookPanel.Controls.Add(ViewBookBtn);
            BookPanel.Controls.Add(bookList);
            BookPanel.Controls.Add(BookLabel);
            BookPanel.Controls.Add(DeleteBookBtn);
            BookPanel.Location = new Point(421, 12);
            BookPanel.Name = "BookPanel";
            BookPanel.Size = new Size(418, 245);
            BookPanel.TabIndex = 1;
            // 
            // AddBookBtn
            // 
            AddBookBtn.Location = new Point(84, 208);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(75, 23);
            AddBookBtn.TabIndex = 3;
            AddBookBtn.Text = "Add";
            AddBookBtn.UseVisualStyleBackColor = true;
            AddBookBtn.Click += AddBookBtn_Click;
            // 
            // ViewBookBtn
            // 
            ViewBookBtn.Location = new Point(3, 208);
            ViewBookBtn.Name = "ViewBookBtn";
            ViewBookBtn.Size = new Size(75, 23);
            ViewBookBtn.TabIndex = 2;
            ViewBookBtn.Text = "View";
            ViewBookBtn.UseVisualStyleBackColor = true;
            ViewBookBtn.Click += ViewBookBtn_Click;
            // 
            // bookList
            // 
            bookList.FormattingEnabled = true;
            bookList.ItemHeight = 15;
            bookList.Location = new Point(3, 18);
            bookList.Name = "bookList";
            bookList.Size = new Size(410, 184);
            bookList.TabIndex = 1;
            bookList.SelectedIndexChanged += bookList_SelectedIndexChanged;
            bookList.DoubleClick += ViewBookBtn_Click;
            // 
            // BookLabel
            // 
            BookLabel.AutoSize = true;
            BookLabel.Location = new Point(3, 0);
            BookLabel.Name = "BookLabel";
            BookLabel.Size = new Size(39, 15);
            BookLabel.TabIndex = 0;
            BookLabel.Text = "Books";
            // 
            // DeleteBookBtn
            // 
            DeleteBookBtn.Location = new Point(165, 208);
            DeleteBookBtn.Name = "DeleteBookBtn";
            DeleteBookBtn.Size = new Size(75, 23);
            DeleteBookBtn.TabIndex = 4;
            DeleteBookBtn.Text = "Delete";
            DeleteBookBtn.UseVisualStyleBackColor = true;
            DeleteBookBtn.Click += DeleteBookBtn_Click;
            // 
            // ScorePanel
            // 
            ScorePanel.BorderStyle = BorderStyle.FixedSingle;
            ScorePanel.Controls.Add(rankList);
            ScorePanel.Controls.Add(RankLabel);
            ScorePanel.Location = new Point(421, 265);
            ScorePanel.Name = "ScorePanel";
            ScorePanel.Size = new Size(418, 102);
            ScorePanel.TabIndex = 2;
            // 
            // rankList
            // 
            rankList.FormattingEnabled = true;
            rankList.ItemHeight = 15;
            rankList.Location = new Point(3, 18);
            rankList.Name = "rankList";
            rankList.Size = new Size(410, 79);
            rankList.TabIndex = 1;
            // 
            // RankLabel
            // 
            RankLabel.AutoSize = true;
            RankLabel.Location = new Point(3, 0);
            RankLabel.Name = "RankLabel";
            RankLabel.Size = new Size(50, 15);
            RankLabel.TabIndex = 0;
            RankLabel.Text = "Ranking";
            // 
            // HistoryPanel
            // 
            HistoryPanel.BorderStyle = BorderStyle.FixedSingle;
            HistoryPanel.Controls.Add(DeadLineList);
            HistoryPanel.Controls.Add(DeadLineLabel);
            HistoryPanel.Location = new Point(12, 264);
            HistoryPanel.Name = "HistoryPanel";
            HistoryPanel.Size = new Size(403, 233);
            HistoryPanel.TabIndex = 3;
            // 
            // DeadLineList
            // 
            DeadLineList.FormattingEnabled = true;
            DeadLineList.ItemHeight = 15;
            DeadLineList.Location = new Point(3, 18);
            DeadLineList.Name = "DeadLineList";
            DeadLineList.Size = new Size(395, 199);
            DeadLineList.TabIndex = 1;
            DeadLineList.SelectedIndexChanged += DeadLineList_SelectedIndexChanged;
            // 
            // DeadLineLabel
            // 
            DeadLineLabel.AutoSize = true;
            DeadLineLabel.Location = new Point(3, 0);
            DeadLineLabel.Name = "DeadLineLabel";
            DeadLineLabel.Size = new Size(61, 15);
            DeadLineLabel.TabIndex = 0;
            DeadLineLabel.Text = "DeadLines";
            // 
            // PrimaryLendRetrievePanel
            // 
            PrimaryLendRetrievePanel.Controls.Add(LendBtn);
            PrimaryLendRetrievePanel.Controls.Add(RetrieveBtn);
            PrimaryLendRetrievePanel.Location = new Point(3, 18);
            PrimaryLendRetrievePanel.Name = "PrimaryLendRetrievePanel";
            PrimaryLendRetrievePanel.Size = new Size(410, 100);
            PrimaryLendRetrievePanel.TabIndex = 6;
            // 
            // LendBtn
            // 
            LendBtn.Location = new Point(53, 8);
            LendBtn.Name = "LendBtn";
            LendBtn.Size = new Size(122, 89);
            LendBtn.TabIndex = 3;
            LendBtn.Text = "Lend";
            LendBtn.UseVisualStyleBackColor = true;
            LendBtn.Click += LendBtn_Click;
            // 
            // RetrieveBtn
            // 
            RetrieveBtn.Location = new Point(240, 8);
            RetrieveBtn.Name = "RetrieveBtn";
            RetrieveBtn.Size = new Size(122, 89);
            RetrieveBtn.TabIndex = 2;
            RetrieveBtn.Text = "Retrieve";
            RetrieveBtn.UseVisualStyleBackColor = true;
            RetrieveBtn.Click += RetrieveBtn_Click;
            // 
            // LendingPanel
            // 
            LendingPanel.BorderStyle = BorderStyle.FixedSingle;
            LendingPanel.Controls.Add(retrievePanel);
            LendingPanel.Controls.Add(PrimaryLendRetrievePanel);
            LendingPanel.Controls.Add(LendingInputPanel);
            LendingPanel.Controls.Add(LendingLabel);
            LendingPanel.Location = new Point(421, 369);
            LendingPanel.Name = "LendingPanel";
            LendingPanel.Size = new Size(418, 128);
            LendingPanel.TabIndex = 4;
            // 
            // retrievePanel
            // 
            retrievePanel.Controls.Add(RetrieveButton);
            retrievePanel.Controls.Add(Cancel2Btn);
            retrievePanel.Controls.Add(deadlineText);
            retrievePanel.Controls.Add(Deadline);
            retrievePanel.Enabled = false;
            retrievePanel.Location = new Point(3, 18);
            retrievePanel.Name = "retrievePanel";
            retrievePanel.Size = new Size(410, 100);
            retrievePanel.TabIndex = 2;
            retrievePanel.Visible = false;
            // 
            // RetrieveButton
            // 
            RetrieveButton.Location = new Point(100, 65);
            RetrieveButton.Name = "RetrieveButton";
            RetrieveButton.Size = new Size(75, 23);
            RetrieveButton.TabIndex = 3;
            RetrieveButton.Text = "Retrieve";
            RetrieveButton.UseVisualStyleBackColor = true;
            RetrieveButton.Click += RetrieveButton_Click;
            // 
            // Cancel2Btn
            // 
            Cancel2Btn.Location = new Point(240, 65);
            Cancel2Btn.Name = "Cancel2Btn";
            Cancel2Btn.Size = new Size(75, 23);
            Cancel2Btn.TabIndex = 2;
            Cancel2Btn.Text = "Cancel";
            Cancel2Btn.UseVisualStyleBackColor = true;
            Cancel2Btn.Click += Cancel2Btn_Click;
            // 
            // deadlineText
            // 
            deadlineText.Location = new Point(162, 21);
            deadlineText.Name = "deadlineText";
            deadlineText.ReadOnly = true;
            deadlineText.Size = new Size(220, 23);
            deadlineText.TabIndex = 1;
            selectionTip.SetToolTip(deadlineText, "Select a deadline from the deadline list");
            // 
            // Deadline
            // 
            Deadline.AutoSize = true;
            Deadline.Location = new Point(23, 24);
            Deadline.Name = "Deadline";
            Deadline.Size = new Size(109, 15);
            Deadline.TabIndex = 0;
            Deadline.Text = "Selected Deadline : ";
            // 
            // LendingInputPanel
            // 
            LendingInputPanel.BorderStyle = BorderStyle.Fixed3D;
            LendingInputPanel.Controls.Add(LendApplyBtn);
            LendingInputPanel.Controls.Add(CancelBtn);
            LendingInputPanel.Controls.Add(DateLabel);
            LendingInputPanel.Controls.Add(dateTimePicker1);
            LendingInputPanel.Controls.Add(LabelBook);
            LendingInputPanel.Controls.Add(BookSelectText);
            LendingInputPanel.Controls.Add(MemberSelectText);
            LendingInputPanel.Controls.Add(memLabel);
            LendingInputPanel.Enabled = false;
            LendingInputPanel.Location = new Point(3, 18);
            LendingInputPanel.Name = "LendingInputPanel";
            LendingInputPanel.Size = new Size(410, 105);
            LendingInputPanel.TabIndex = 1;
            LendingInputPanel.Visible = false;
            // 
            // LendApplyBtn
            // 
            LendApplyBtn.Location = new Point(328, 46);
            LendApplyBtn.Name = "LendApplyBtn";
            LendApplyBtn.Size = new Size(75, 23);
            LendApplyBtn.TabIndex = 5;
            LendApplyBtn.Text = "Lend";
            LendApplyBtn.UseVisualStyleBackColor = true;
            LendApplyBtn.Click += LendApplyBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(328, 75);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 4;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(3, 67);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(89, 15);
            DateLabel.TabIndex = 3;
            DateLabel.Text = "Deadline Date : ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(98, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // LabelBook
            // 
            LabelBook.AutoSize = true;
            LabelBook.Location = new Point(21, 35);
            LabelBook.Name = "LabelBook";
            LabelBook.Size = new Size(43, 15);
            LabelBook.TabIndex = 3;
            LabelBook.Text = "Book : ";
            // 
            // BookSelectText
            // 
            BookSelectText.Location = new Point(70, 32);
            BookSelectText.Name = "BookSelectText";
            BookSelectText.ReadOnly = true;
            BookSelectText.Size = new Size(239, 23);
            BookSelectText.TabIndex = 2;
            selectionTip.SetToolTip(BookSelectText, "Select a book from the books list.");
            // 
            // MemberSelectText
            // 
            MemberSelectText.Location = new Point(70, 3);
            MemberSelectText.Name = "MemberSelectText";
            MemberSelectText.ReadOnly = true;
            MemberSelectText.Size = new Size(239, 23);
            MemberSelectText.TabIndex = 1;
            selectionTip.SetToolTip(MemberSelectText, "Select a member from the members list.\r\n");
            // 
            // memLabel
            // 
            memLabel.AutoSize = true;
            memLabel.Location = new Point(3, 6);
            memLabel.Name = "memLabel";
            memLabel.Size = new Size(61, 15);
            memLabel.TabIndex = 0;
            memLabel.Text = "Member : ";
            // 
            // LendingLabel
            // 
            LendingLabel.AutoSize = true;
            LendingLabel.Location = new Point(3, 0);
            LendingLabel.Name = "LendingLabel";
            LendingLabel.Size = new Size(119, 15);
            LendingLabel.TabIndex = 0;
            LendingLabel.Text = "Lend/Retrieve a book\r\n";
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(768, 517);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(75, 23);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // selectionTip
            // 
            selectionTip.AutoPopDelay = 5000;
            selectionTip.InitialDelay = 50;
            selectionTip.ReshowDelay = 50;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(855, 552);
            Controls.Add(CloseBtn);
            Controls.Add(LendingPanel);
            Controls.Add(HistoryPanel);
            Controls.Add(ScorePanel);
            Controls.Add(BookPanel);
            Controls.Add(MemberPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "Library Manager";
            MemberPanel.ResumeLayout(false);
            MemberPanel.PerformLayout();
            BookPanel.ResumeLayout(false);
            BookPanel.PerformLayout();
            ScorePanel.ResumeLayout(false);
            ScorePanel.PerformLayout();
            HistoryPanel.ResumeLayout(false);
            HistoryPanel.PerformLayout();
            PrimaryLendRetrievePanel.ResumeLayout(false);
            LendingPanel.ResumeLayout(false);
            LendingPanel.PerformLayout();
            retrievePanel.ResumeLayout(false);
            retrievePanel.PerformLayout();
            LendingInputPanel.ResumeLayout(false);
            LendingInputPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MemberPanel;
        private Panel BookPanel;
        private Panel ScorePanel;
        private Panel HistoryPanel;
        private Label MemberLabel;
        private Label BookLabel;
        private Button ViewMemberBtn;
        private Label RankLabel;
        private Label DeadLineLabel;
        private Button DeleteMemberBtn;
        private Button AddMemberBtn;
        private ListBox memberList;
        private Button DeleteBookBtn;
        private Button AddBookBtn;
        private Button ViewBookBtn;
        private ListBox bookList;
        private ListBox rankList;
        private ListBox DeadLineList;
        private Panel LendingPanel;
        private Label LendingLabel;
        private Panel LendingInputPanel;
        private Label memLabel;
        private Button CloseBtn;
        private Label DateLabel;
        private DateTimePicker dateTimePicker1;
        private Label LabelBook;
        private TextBox BookSelectText;
        private TextBox MemberSelectText;
        private ToolTip selectionTip;
        private Button LendBtn;
        private Button RetrieveBtn;
        private Panel PrimaryLendRetrievePanel;
        private Button LendApplyBtn;
        private Button CancelBtn;
        private Panel retrievePanel;
        private Label Deadline;
        private Button RetrieveButton;
        private Button Cancel2Btn;
        private TextBox deadlineText;
    }
}
