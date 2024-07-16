using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Entities;
using LMS.Exceptions;

namespace LMS.Forms
{
    public partial class MemberAddition : Form
    {
        public MemberAddition(MainWindow mainWindow)
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
            int id;

            try
            {
                bool b = int.TryParse(IDText.Text, out id);
                if (!b)
                {
                    throw new InvalidInputID();
                }
            }

            catch ( InvalidInputID ex )
            {
                ex.ShowErrorMessage();
                return;
            }

            if (membershipTypeCombo.SelectedItem == null)
            {
                MessageBox.Show("Select a membership type.", "Info not complete!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var memShip = membershipTypeCombo.SelectedItem.ToString();

            var newMember = new Member(id, FirstNameText.Text, LastNameText.Text, memShip, 0);

            newMember.AddMemberToExcel();

            mainWindow.ShowMemberList();
            mainWindow.ShowRankList();
            this.Close();
        }
    }
}
