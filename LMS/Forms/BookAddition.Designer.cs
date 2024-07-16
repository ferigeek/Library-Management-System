namespace LMS.Forms
{
    partial class BookAddition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAddition));
            CodeLabel = new Label();
            CodeText = new TextBox();
            TitleText = new TextBox();
            AuthorText = new TextBox();
            GenreText = new TextBox();
            TitleLabel = new Label();
            AuthorLabel = new Label();
            GenreLabel = new Label();
            CloseBtn = new Button();
            AddBtn = new Button();
            SuspendLayout();
            // 
            // CodeLabel
            // 
            CodeLabel.AutoSize = true;
            CodeLabel.Location = new Point(21, 21);
            CodeLabel.Name = "CodeLabel";
            CodeLabel.Size = new Size(44, 15);
            CodeLabel.TabIndex = 0;
            CodeLabel.Text = "Code : ";
            // 
            // CodeText
            // 
            CodeText.Location = new Point(80, 18);
            CodeText.Name = "CodeText";
            CodeText.Size = new Size(100, 23);
            CodeText.TabIndex = 1;
            // 
            // TitleText
            // 
            TitleText.Location = new Point(80, 47);
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(100, 23);
            TitleText.TabIndex = 2;
            // 
            // AuthorText
            // 
            AuthorText.Location = new Point(80, 76);
            AuthorText.Name = "AuthorText";
            AuthorText.Size = new Size(100, 23);
            AuthorText.TabIndex = 3;
            // 
            // GenreText
            // 
            GenreText.Location = new Point(80, 105);
            GenreText.Name = "GenreText";
            GenreText.Size = new Size(100, 23);
            GenreText.TabIndex = 4;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(27, 50);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(38, 15);
            TitleLabel.TabIndex = 5;
            TitleLabel.Text = "Title : ";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(12, 79);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(53, 15);
            AuthorLabel.TabIndex = 6;
            AuthorLabel.Text = "Author : ";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(18, 108);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(47, 15);
            GenreLabel.TabIndex = 7;
            GenreLabel.Text = "Genre : ";
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(138, 169);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(75, 23);
            CloseBtn.TabIndex = 8;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(57, 169);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 9;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // BookAddition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 204);
            Controls.Add(AddBtn);
            Controls.Add(CloseBtn);
            Controls.Add(GenreLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(TitleLabel);
            Controls.Add(GenreText);
            Controls.Add(AuthorText);
            Controls.Add(TitleText);
            Controls.Add(CodeText);
            Controls.Add(CodeLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BookAddition";
            Text = "Add a Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CodeLabel;
        private TextBox CodeText;
        private TextBox TitleText;
        private TextBox AuthorText;
        private TextBox GenreText;
        private Label TitleLabel;
        private Label AuthorLabel;
        private Label GenreLabel;
        private Button CloseBtn;
        private Button AddBtn;
    }
}