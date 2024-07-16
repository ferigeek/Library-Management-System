using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Exceptions
{
    public class InputException : Exception
    {
        private string message { get; set; }
        private string caption {  get; set; }

        public InputException( string message, string caption ) : base( message )
        {
            this.message = message;
            this.caption = caption;
        }

        public InputException ()
        {
            message = "Invalid input is Entered!";
            caption = "Invalid Input!";
        }

        public virtual void ShowErrorMessage ()
        {
            MessageBox.Show( message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
    }
}
