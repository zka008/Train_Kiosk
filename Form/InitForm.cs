using System;
using System.Windows.Forms;
using kiosk.DataBase;
using kiosk.Service;

namespace kiosk
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            if (LoginControl.Instance.LoggedInMemberEmail == null)
            {
                MessageBox.Show("로그인 후 이용 가능합니다");
                return;
            }
            ReservationForm reservation_UserInfo_Form = new ReservationForm();
            reservation_UserInfo_Form.StartPosition = FormStartPosition.CenterScreen;
            reservation_UserInfo_Form.Show();
        }

        private void btnInquery_Click(object sender, EventArgs e)
        {
            if(LoginControl.Instance.LoggedInMemberEmail == null)
            {
                MessageBox.Show("로그인 후 이용 가능합니다");
                return;
            }
            Ticket inquery_UserInfo_Form = new Ticket();
            inquery_UserInfo_Form.StartPosition = FormStartPosition.CenterScreen;
            inquery_UserInfo_Form.Show();
        }

        private void btbLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.StartPosition = FormStartPosition.CenterScreen;
            registerForm.Show();
        }
    }
}
