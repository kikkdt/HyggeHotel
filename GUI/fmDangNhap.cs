using BLL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public static Main mainForm;
        public fmDangNhap()
        {
            InitializeComponent();

        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            if (IsValidateForm())
            {
                if (TaiKhoanBLL.checkUsernameExist(txtUsername.Text))
                {
                    if (TaiKhoanBLL.checkPassword(txtUsername.Text, txtPassword.Text))
                    {
                        mainForm = new Main(txtUsername.Text);
                        mainForm.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng.");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                }
            }
        }

        private void FmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ErrorProvider errorProvider = new ErrorProvider();

        private bool IsValidateForm()
        {
            return IsValidateUsername() && IsValidatePassword();
        }

        private bool IsValidateUsername()
        {
            if (txtUsername.Text.Trim() == String.Empty)
            {
                errorProvider.SetError(txtUsername, "Tên đăng nhập không được để trống");
                return false;
            }
            else
            {
                errorProvider.Clear();
                return true;
            }
        }


        private bool IsValidatePassword()
        {
            if (txtPassword.Text.Trim() == String.Empty)
            {
                errorProvider.SetError(txtPassword, "Mật khẩu không được để trống");
                return false;
            }
            else
            {
                errorProvider.Clear();
                return true;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            IsValidateUsername();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            IsValidatePassword();
        }
    }
}