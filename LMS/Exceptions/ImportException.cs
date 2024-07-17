using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Exceptions
{
    internal class ImportException : InputException
    {
        private string message { get; set; }
        private string caption { get; set; }
        private string type { get; set; }
        private int row { get; set; }

        public ImportException(string message, string caption, string type, int row) : base(message, caption)
        {
            this.caption = "Import Error!";
            this.type = type;
            this.row = row;
        }

        public override void ShowErrorMessage()
        {
            MessageBox.Show($"Can't import {type} at row {row}", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
