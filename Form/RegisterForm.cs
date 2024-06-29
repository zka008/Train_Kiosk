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

namespace kiosk
{
    public partial class RegisterForm : Form
    {
        MySQLHandler handler = new MySQLHandler();
        bool check = false;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("개인정보 수집에 동의 해주세요");
                return;
            }
            if (textEmail.Text == "")
            {
                MessageBox.Show("이메일을 입력해주세요");
                return;
            }
            if (textPassword.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요");
                return;
            }
            if (textName.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요");
                return;
            }
            if (textTel1.Text == "" || textTel2.Text == "" || textTel3.Text == "")
            {
                MessageBox.Show("전화번호를 입력해주세요");
                return;
            }
            if (textBirth.Text == "" || textIdentify.Text == "")
            {
                MessageBox.Show("주민번호를 입력해주세요");
                return;
            }
            string tel = textTel1.Text + "-" + textTel2.Text + "-" + textTel3.Text;
            handler.RegisterMember(textEmail.Text, textPassword.Text, textName.Text, tel, textIdentify.Text);
            MessageBox.Show("회원가입 완료");
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAgree.Checked)
                check = true;
            else
                check = false;
        }

        private void radioDisAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDisAgree.Checked)
                check = false;
            else
                check = true;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            radioDisAgree.Checked = false;
            radioAgree.Checked = false;
        }
    }
}
