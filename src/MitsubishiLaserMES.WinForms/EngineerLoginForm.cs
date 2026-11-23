using System;
using System.Windows.Forms;

namespace MitsubishiLaserMES.WinForms
{
    public partial class EngineerLoginForm : Form
    {
        private readonly string _correctPassword;

        public EngineerLoginForm() : this("1234")
        {
        }

        public EngineerLoginForm(string correctPassword)
        {
            InitializeComponent();
            _correctPassword = correctPassword;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == _correctPassword)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(this, "密碼錯誤，無法進入工程師模式！", "權限驗證失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
