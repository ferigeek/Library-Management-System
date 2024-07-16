using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Exceptions
{
    internal class InvalidInputCode : InputException
    {
        private string message { get; set; }
        private string caption { get; set; }

        public InvalidInputCode()
        {
            message = "The Code should be just digits.";
            caption = "Invalid Input Code!";
        }

        public InvalidInputCode(string message, string caption) : base(message, caption)
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
