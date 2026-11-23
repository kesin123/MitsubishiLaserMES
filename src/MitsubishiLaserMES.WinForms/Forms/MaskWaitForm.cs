using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MitsubishiLaserMES.WinForms.Forms
{
    public partial class MaskWaitForm : Form
    {
        public MaskWaitForm() : this("系統處理中，請稍候...")
        {
        }

        public MaskWaitForm(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        public static async Task<T> RunWithWaitAsync<T>(Form parent, string message, Func<Task<T>> action)
        {
            using var form = new MaskWaitForm(message);
            Task<T> actionTask = action();

            form.Shown += async (s, e) =>
            {
                try
                {
                    await actionTask;
                }
                catch { }
                finally
                {
                    if (!form.IsDisposed)
                    {
                        form.Close();
                    }
                }
            };

            form.ShowDialog(parent);
            return await actionTask;
        }
    }
}
