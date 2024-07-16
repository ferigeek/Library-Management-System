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
            MemberPanel.SuspendLayout();
            BookPanel.SuspendLayout();
            ScorePanel.SuspendLayout();
            HistoryPanel.SuspendLayout();
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
            ScorePanel.Location = new Point(12, 263);
            ScorePanel.Name = "ScorePanel";
            ScorePanel.Size = new Size(312, 131);
            ScorePanel.TabIndex = 2;
            // 
            // rankList
            // 
            rankList.FormattingEnabled = true;
            rankList.ItemHeight = 15;
            rankList.Location = new Point(3, 18);
            rankList.Name = "rankList";
            rankList.Size = new Size(304, 109);
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
            HistoryPanel.Location = new Point(12, 400);
            HistoryPanel.Name = "HistoryPanel";
            HistoryPanel.Size = new Size(312, 140);
            HistoryPanel.TabIndex = 3;
            // 
            // DeadLineList
            // 
            DeadLineList.FormattingEnabled = true;
            DeadLineList.ItemHeight = 15;
            DeadLineList.Location = new Point(3, 18);
            DeadLineList.Name = "DeadLineList";
            DeadLineList.Size = new Size(304, 109);
            DeadLineList.TabIndex = 1;
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
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(855, 552);
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
    }
}
