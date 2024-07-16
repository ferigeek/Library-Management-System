namespace LMS.Forms
{
    partial class MemberAddition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberAddition));
            IDLabel = new Label();
            FirstLabel = new Label();
            LastLabel = new Label();
            MembershipLabel = new Label();
            IDText = new TextBox();
            FirstNameText = new TextBox();
            LastNameText = new TextBox();
            membershipTypeCombo = new ComboBox();
            CloseBtn = new Button();
            AddBtn = new Button();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(95, 17);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(24, 15);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID :";
            // 
            // FirstLabel
            // 
            FirstLabel.AutoSize = true;
            FirstLabel.Location = new Point(49, 54);
            FirstLabel.Name = "FirstLabel";
            FirstLabel.Size = new Size(70, 15);
            FirstLabel.TabIndex = 1;
            FirstLabel.Text = "First Name :";
            // 
            // LastLabel
            // 
            LastLabel.AutoSize = true;
            LastLabel.Location = new Point(49, 92);
            LastLabel.Name = "LastLabel";
            LastLabel.Size = new Size(69, 15);
            LastLabel.TabIndex = 2;
            LastLabel.Text = "Last Name :";
            // 
            // MembershipLabel
            // 
            MembershipLabel.AutoSize = true;
            MembershipLabel.Location = new Point(12, 129);
            MembershipLabel.Name = "MembershipLabel";
            MembershipLabel.Size = new Size(107, 15);
            MembershipLabel.TabIndex = 3;
            MembershipLabel.Text = "Membership Type :";
            // 
            // IDText
            // 
            IDText.Location = new Point(125, 14);
            IDText.Name = "IDText";
            IDText.Size = new Size(99, 23);
            IDText.TabIndex = 4;
            // 
            // FirstNameText
            // 
            FirstNameText.Location = new Point(125, 51);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(100, 23);
            FirstNameText.TabIndex = 5;
            // 
            // LastNameText
            // 
            LastNameText.Location = new Point(124, 89);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(100, 23);
            LastNameText.TabIndex = 6;
            // 
            // membershipTypeCombo
            // 
            membershipTypeCombo.FormattingEnabled = true;
            membershipTypeCombo.Items.AddRange(new object[] { "Normal", "VIP" });
            membershipTypeCombo.Location = new Point(125, 126);
            membershipTypeCombo.Name = "membershipTypeCombo";
            membershipTypeCombo.Size = new Size(121, 23);
            membershipTypeCombo.TabIndex = 7;
            membershipTypeCombo.Text = "--Select--";
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(179, 177);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(75, 23);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(98, 177);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 9;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // MemberAddition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 212);
            Controls.Add(AddBtn);
            Controls.Add(CloseBtn);
            Controls.Add(membershipTypeCombo);
            Controls.Add(LastNameText);
            Controls.Add(FirstNameText);
            Controls.Add(IDText);
            Controls.Add(MembershipLabel);
            Controls.Add(LastLabel);
            Controls.Add(FirstLabel);
            Controls.Add(IDLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MemberAddition";
            Text = "Add a Member";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDLabel;
        private Label FirstLabel;
        private Label LastLabel;
        private Label MembershipLabel;
        private TextBox IDText;
        private TextBox FirstNameText;
        private TextBox LastNameText;
        private ComboBox membershipTypeCombo;
        private Button CloseBtn;
        private Button AddBtn;
    }
}