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
    public partial class PayForm : Form
    {
        MySQLHandler handler = new MySQLHandler();
        public PayForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결재가 완료 되었습니다");
            this.Close();
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            textName.Text = LoginControl.Instance.LoggedInMemberName;
            textTel.Text = LoginControl.Instance.LoggedInMemberTel;
            List<TicketInfo> ticket = handler.GetTicket(LoginControl.Instance.LoggedInMemberName);
            textDeparture.Text = ticket[0].Ticket.DepartureStation;
            textDepartureT.Text = ticket[0].Ticket.DepartureTime;
            textArrive.Text = ticket[0].Ticket.ArriveStation;
            textArriveT.Text = ticket[0].Ticket.ArriveTime;

            comboBox1.Items.Add("카드");
            comboBox1.Items.Add("무통장");
            comboBox2.Items.Add("삼성");
            comboBox2.Items.Add("현대");
            comboBox2.Items.Add("국민");
            comboBox2.Items.Add("신한");
        }
    }
}
