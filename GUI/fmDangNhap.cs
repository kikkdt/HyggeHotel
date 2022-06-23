using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public static Main mainForm;

        private readonly ErrorProvider errorProvider = new ErrorProvider();

        public fmDangNhap()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidateForm())
                {
                    if (TaiKhoanBLL.checkUsernameExist(txtUsername.Text))
                    {
                        if (TaiKhoanBLL.checkPassword(txtUsername.Text, txtPassword.Text))
                        {
                            mainForm = new Main(txtUsername.Text);
                            mainForm.Show();
                            Visible = false;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnLogin_MouseHover(object sender, EventArgs e)
        {
            btnDangNhap.Appearance.BackColor = Color.Crimson;
            btnDangNhap.Appearance.ForeColor = Color.White;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnDangNhap.Appearance.BackColor = Color.White;
            btnDangNhap.Appearance.ForeColor = Color.Black;
        }

        private bool IsValidateForm()
        {
            return IsValidateUsername() && IsValidatePassword();
        }

        private bool IsValidateUsername()
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                errorProvider.SetError(txtUsername, "Tên đăng nhập không được để trống");
                return false;
            }

            errorProvider.Clear();
            return true;
        }

        private bool IsValidatePassword()
        {
            if (txtPassword.Text.Trim() == string.Empty)
            {
                errorProvider.SetError(txtPassword, "Mật khẩu không được để trống");
                return false;
            }

            errorProvider.Clear();
            return true;
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