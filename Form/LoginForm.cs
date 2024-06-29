using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kiosk.DataBase;
using kiosk.Service;
namespace kiosk
{
    public partial class LoginForm : Form
    {
        MySQLHandler handler = new MySQLHandler();   
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(textID.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요");
                return;
            }
            if(textPW.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요");
                return;
            }
            if (LoginControl.Instance.Login(textID.Text, textPW.Text))
            {
                MessageBox.Show("로그인에 성공했습니다");
                this.Close();
            }
            else
            {
                MessageBox.Show("아이디 혹은 비밀번호가 일치하지 않습니다.");
                return;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
