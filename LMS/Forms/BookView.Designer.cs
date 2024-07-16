namespace LMS.Forms
{
    partial class BookView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookView));
            informationPanel = new Panel();
            GenreText = new TextBox();
            GenreLabel = new Label();
            BorrowedText = new TextBox();
            BorrowedLabel = new Label();
            CodeLabel = new Label();
            CodeText = new TextBox();
            AuthorText = new TextBox();
            AuthorLabel = new Label();
            TitleText = new TextBox();
            TitleLabel = new Label();
            CloseBtn = new Button();
            EditBtn = new Button();
            ApplyBtn = new Button();
            informationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // informationPanel
            // 
            informationPanel.Controls.Add(GenreText);
            informationPanel.Controls.Add(GenreLabel);
            informationPanel.Controls.Add(BorrowedText);
            informationPanel.Controls.Add(BorrowedLabel);
            informationPanel.Controls.Add(CodeLabel);
            informationPanel.Controls.Add(CodeText);
            informationPanel.Controls.Add(AuthorText);
            informationPanel.Controls.Add(AuthorLabel);
            informationPanel.Controls.Add(TitleText);
            informationPanel.Controls.Add(TitleLabel);
            informationPanel.Location = new Point(12, 12);
            informationPanel.Name = "informationPanel";
            informationPanel.Size = new Size(306, 186);
            informationPanel.TabIndex = 0;
            // 
            // GenreText
            // 
            GenreText.Location = new Point(92, 146);
            GenreText.Name = "GenreText";
            GenreText.ReadOnly = true;
            GenreText.Size = new Size(155, 23);
            GenreText.TabIndex = 9;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(39, 149);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(47, 15);
            GenreLabel.TabIndex = 8;
            GenreLabel.Text = "Genre : ";
            // 
            // BorrowedText
            // 
            BorrowedText.Location = new Point(92, 111);
            BorrowedText.Name = "BorrowedText";
            BorrowedText.ReadOnly = true;
            BorrowedText.Size = new Size(155, 23);
            BorrowedText.TabIndex = 7;
            // 
            // BorrowedLabel
            // 
            BorrowedLabel.AutoSize = true;
            BorrowedLabel.Location = new Point(3, 114);
            BorrowedLabel.Name = "BorrowedLabel";
            BorrowedLabel.Size = new Size(83, 15);
            BorrowedLabel.TabIndex = 6;
            BorrowedLabel.Text = "Borrowed By : ";
            // 
            // CodeLabel
            // 
            CodeLabel.AutoSize = true;
            CodeLabel.Location = new Point(42, 81);
            CodeLabel.Name = "CodeLabel";
            CodeLabel.Size = new Size(44, 15);
            CodeLabel.TabIndex = 5;
            CodeLabel.Text = "Code : ";
            // 
            // CodeText
            // 
            CodeText.Location = new Point(92, 78);
            CodeText.Name = "CodeText";
            CodeText.ReadOnly = true;
            CodeText.Size = new Size(100, 23);
            CodeText.TabIndex = 4;
            // 
            // AuthorText
            // 
            AuthorText.Location = new Point(92, 42);
            AuthorText.Name = "AuthorText";
            AuthorText.ReadOnly = true;
            AuthorText.Size = new Size(155, 23);
            AuthorText.TabIndex = 3;
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(33, 45);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(53, 15);
            AuthorLabel.TabIndex = 2;
            AuthorLabel.Text = "Author : ";
            // 
            // TitleText
            // 
            TitleText.Location = new Point(92, 8);
            TitleText.Name = "TitleText";
            TitleText.ReadOnly = true;
            TitleText.Size = new Size(155, 23);
            TitleText.TabIndex = 1;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(48, 16);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(38, 15);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Title : ";
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(243, 220);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(75, 23);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(160, 220);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(75, 23);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // ApplyBtn
            // 
            ApplyBtn.Enabled = false;
            ApplyBtn.Location = new Point(160, 220);
            ApplyBtn.Name = "ApplyBtn";
            ApplyBtn.Size = new Size(75, 23);
            ApplyBtn.TabIndex = 3;
            ApplyBtn.Text = "Apply";
            ApplyBtn.UseVisualStyleBackColor = true;
            ApplyBtn.Visible = false;
            ApplyBtn.Click += ApplyBtn_Click;
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 255);
            Controls.Add(ApplyBtn);
            Controls.Add(EditBtn);
            Controls.Add(CloseBtn);
            Controls.Add(informationPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BookView";
            Text = "Book Information";
            informationPanel.ResumeLayout(false);
            informationPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel informationPanel;
        private Label TitleLabel;
        private Label AuthorLabel;
        private TextBox TitleText;
        private Label CodeLabel;
        private TextBox CodeText;
        private TextBox AuthorText;
        private TextBox BorrowedText;
        private Label BorrowedLabel;
        private Button CloseBtn;
        private Button EditBtn;
        private Label GenreLabel;
        private TextBox GenreText;
        private Button ApplyBtn;
    }
}