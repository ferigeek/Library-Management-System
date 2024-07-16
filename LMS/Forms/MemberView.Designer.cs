namespace LMS.Forms
{
    partial class MemberView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberView));
            infoPanel = new Panel();
            ScoreText = new TextBox();
            MembershipText = new TextBox();
            IDText = new TextBox();
            LastNameText = new TextBox();
            FirstNameText = new TextBox();
            ScoreLabel = new Label();
            MembershipLabel = new Label();
            IDLabel = new Label();
            LastNameLabel = new Label();
            FirstNameLabel = new Label();
            panel2 = new Panel();
            BorrowedBooksList = new ListBox();
            borrowedLabel = new Label();
            closeBtn = new Button();
            EditBtn = new Button();
            ApplyBtn = new Button();
            infoPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // infoPanel
            // 
            infoPanel.Controls.Add(ScoreText);
            infoPanel.Controls.Add(MembershipText);
            infoPanel.Controls.Add(IDText);
            infoPanel.Controls.Add(LastNameText);
            infoPanel.Controls.Add(FirstNameText);
            infoPanel.Controls.Add(ScoreLabel);
            infoPanel.Controls.Add(MembershipLabel);
            infoPanel.Controls.Add(IDLabel);
            infoPanel.Controls.Add(LastNameLabel);
            infoPanel.Controls.Add(FirstNameLabel);
            infoPanel.Location = new Point(12, 12);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(306, 188);
            infoPanel.TabIndex = 0;
            // 
            // ScoreText
            // 
            ScoreText.BorderStyle = BorderStyle.FixedSingle;
            ScoreText.Location = new Point(98, 132);
            ScoreText.Name = "ScoreText";
            ScoreText.ReadOnly = true;
            ScoreText.Size = new Size(64, 23);
            ScoreText.TabIndex = 9;
            // 
            // MembershipText
            // 
            MembershipText.BorderStyle = BorderStyle.FixedSingle;
            MembershipText.Location = new Point(98, 97);
            MembershipText.Name = "MembershipText";
            MembershipText.ReadOnly = true;
            MembershipText.Size = new Size(64, 23);
            MembershipText.TabIndex = 8;
            // 
            // IDText
            // 
            IDText.BorderStyle = BorderStyle.FixedSingle;
            IDText.Location = new Point(98, 64);
            IDText.Name = "IDText";
            IDText.ReadOnly = true;
            IDText.Size = new Size(64, 23);
            IDText.TabIndex = 7;
            // 
            // LastNameText
            // 
            LastNameText.BorderStyle = BorderStyle.FixedSingle;
            LastNameText.Location = new Point(98, 35);
            LastNameText.Name = "LastNameText";
            LastNameText.ReadOnly = true;
            LastNameText.Size = new Size(143, 23);
            LastNameText.TabIndex = 6;
            // 
            // FirstNameText
            // 
            FirstNameText.BorderStyle = BorderStyle.FixedSingle;
            FirstNameText.Location = new Point(98, 5);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.ReadOnly = true;
            FirstNameText.Size = new Size(143, 23);
            FirstNameText.TabIndex = 5;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Location = new Point(47, 134);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(45, 15);
            ScoreLabel.TabIndex = 4;
            ScoreLabel.Text = "Score : ";
            // 
            // MembershipLabel
            // 
            MembershipLabel.AutoSize = true;
            MembershipLabel.Location = new Point(9, 99);
            MembershipLabel.Name = "MembershipLabel";
            MembershipLabel.Size = new Size(83, 15);
            MembershipLabel.TabIndex = 3;
            MembershipLabel.Text = "Membership : ";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(65, 66);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(27, 15);
            IDLabel.TabIndex = 2;
            IDLabel.Text = "ID : ";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(20, 37);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(72, 15);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "Last Name : ";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(19, 7);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(73, 15);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name : ";
            // 
            // panel2
            // 
            panel2.Controls.Add(BorrowedBooksList);
            panel2.Location = new Point(12, 236);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 100);
            panel2.TabIndex = 1;
            // 
            // BorrowedBooksList
            // 
            BorrowedBooksList.FormattingEnabled = true;
            BorrowedBooksList.ItemHeight = 15;
            BorrowedBooksList.Location = new Point(3, 3);
            BorrowedBooksList.Name = "BorrowedBooksList";
            BorrowedBooksList.Size = new Size(300, 94);
            BorrowedBooksList.TabIndex = 0;
            // 
            // borrowedLabel
            // 
            borrowedLabel.AutoSize = true;
            borrowedLabel.Location = new Point(120, 218);
            borrowedLabel.Name = "borrowedLabel";
            borrowedLabel.Size = new Size(93, 15);
            borrowedLabel.TabIndex = 2;
            borrowedLabel.Text = "Borrowed Books";
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(243, 386);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 23);
            closeBtn.TabIndex = 0;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(162, 386);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(75, 23);
            EditBtn.TabIndex = 4;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // ApplyBtn
            // 
            ApplyBtn.Enabled = false;
            ApplyBtn.Location = new Point(162, 386);
            ApplyBtn.Name = "ApplyBtn";
            ApplyBtn.Size = new Size(75, 23);
            ApplyBtn.TabIndex = 5;
            ApplyBtn.Text = "Apply";
            ApplyBtn.UseVisualStyleBackColor = true;
            ApplyBtn.Visible = false;
            ApplyBtn.Click += ApplyBtn_Click;
            // 
            // MemberView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(330, 421);
            Controls.Add(ApplyBtn);
            Controls.Add(EditBtn);
            Controls.Add(closeBtn);
            Controls.Add(borrowedLabel);
            Controls.Add(panel2);
            Controls.Add(infoPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MemberView";
            ShowInTaskbar = false;
            Text = "Member Info";
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel infoPanel;
        private Label MembershipLabel;
        private Label IDLabel;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private Panel panel2;
        private Label ScoreLabel;
        private Label borrowedLabel;
        private TextBox FirstNameText;
        private Button closeBtn;
        private Button EditBtn;
        private TextBox ScoreText;
        private TextBox MembershipText;
        private TextBox IDText;
        private TextBox LastNameText;
        private Button ApplyBtn;
        private ListBox BorrowedBooksList;
    }
}