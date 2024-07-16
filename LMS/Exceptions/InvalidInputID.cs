using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Exceptions
{
    public class InvalidInputID : InputException
    {
        private string message {  get; set; }
        private string caption { get; set; }

        public InvalidInputID()
        {
            message = "The ID should be just digits.";
            caption = "Invalid Input ID!";
        }

        public InvalidInputID ( string message, string caption ) : base ( message, caption )
        {
            this.message = message;
            this.caption = caption;
        }

        public override void ShowErrorMessage()
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
