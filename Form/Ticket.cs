using kiosk.DataBase;
using kiosk.DTO;
using kiosk.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk
{
    public partial class Ticket : Form
    {
        MySQLHandler handler = new MySQLHandler();
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            textName.Text = LoginControl.Instance.LoggedInMemberName;
            textID.Text = LoginControl.Instance.LoggedInMemberEmail;
            textTel.Text = LoginControl.Instance.LoggedInMemberTel;
            List<TicketInfo> ticketList = handler.GetTicket(LoginControl.Instance.LoggedInMemberEmail);
            if (ticketList.Count > 0)
                CreateTicketInfo(ticketList);
            else
                MessageBox.Show("예약한 탑승권이 없습니다");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int interval = 0; 
        int cnt = 1;
        private void CreateTicketInfo(List<TicketInfo> ticketList)
        {
            foreach (TicketInfo ticket in ticketList)
            {
                // 그룹박스 생성
                GroupBox groupBox = new GroupBox();
                groupBox.Text = "티켓 " + cnt++;
                groupBox.Location = new Point(32, 185 + interval);
                groupBox.Size = new Size(504, 142);
                this.Controls.Add(groupBox);
                interval += 180;

                // 라벨 생성
                Label label1 = new Label();
                label1.Text = "예약일자";
                label1.Location = new Point(38, 35);
                label1.Size = new Size(59, 15);
                groupBox.Controls.Add(label1);
                Label label2 = new Label();
                label2.Text = "출발";
                label2.Location = new Point(38, 89);
                label2.Size = new Size(31, 15);
                groupBox.Controls.Add(label2);
                Label label3 = new Label();
                label3.Text = "→";
                label3.Font = new Font("맑은 고딕", 12, System.Drawing.FontStyle.Bold);
                label3.Location = new Point(238, 84);
                label3.Size = new Size(26, 21);
                groupBox.Controls.Add(label3);
                Label label4 = new Label();
                label4.Text = "도착";
                label4.Location = new Point(303, 89);
                label4.Size = new Size(31, 15);
                groupBox.Controls.Add(label4);

                //텍스트 박스 생성
                TextBox textBox1 = new TextBox();
                textBox1.Text = ticket.Ticket.Date;
                textBox1.Location = new Point(103, 32);
                textBox1.Size = new Size(100, 23);
                textBox1.Enabled = false;
                groupBox.Controls.Add(textBox1);
                TextBox textBox2 = new TextBox();
                textBox2.Text = ticket.Ticket.DepartureStation;
                textBox2.Location = new Point(103, 71);
                textBox2.Size = new Size(100, 23);
                textBox2.Enabled = false;
                groupBox.Controls.Add(textBox2);
                TextBox textBox3 = new TextBox();
                textBox3.Text = ticket.Ticket.DepartureTime;
                textBox3.Location = new Point(103, 100);
                textBox3.Size = new Size(100, 23);
                textBox3.Enabled = false;
                groupBox.Controls.Add(textBox3);
                TextBox textBox4 = new TextBox();
                textBox4.Text = ticket.Ticket.ArriveStation;
                textBox4.Location = new Point(364, 71);
                textBox4.Size = new Size(100, 23);
                textBox4.Enabled = false;
                groupBox.Controls.Add(textBox4);
                TextBox textBox5 = new TextBox();
                textBox5.Text = ticket.Ticket.ArriveTime;
                textBox5.Location = new Point(364, 100);
                textBox5.Size = new Size(100, 23);
                textBox5.Enabled = false;
                groupBox.Controls.Add(textBox5);
            }
            Button btn = new Button();
            btn.Text = "확인";
            btn.Location = new Point(247, 170+interval);
            btn.Size = new Size(76, 45);
            btn.Margin = new Padding(0, 0, 0, 15);
            btn.Click += btnClose_Click;
            this.Controls.Add(btn);
        }
    }
}
