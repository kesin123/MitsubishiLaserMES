using System;
using System.Windows.Forms;

namespace MitsubishiLaserMES.WinForms.Forms
{
    public partial class TerminalMessageForm : Form
    {
        public TerminalMessageForm() : this(string.Empty)
        {
        }

        public TerminalMessageForm(string message)
        {
            InitializeComponent();
            txtContent.Text = message;
        }
    }
}
