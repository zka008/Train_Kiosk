using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kiosk.API;
using kiosk.DataBase;
using kiosk.DTO;
using kiosk.Service;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace kiosk
{
    public partial class ReservationForm : Form
    {
        MySQLHandler handler = new MySQLHandler();
        List<City> cityList;
        List<TrainStation> departureStationList;
        List<TrainStation> arriveStationList;
        List<TrainType> typeList;

        public ReservationForm()
        {
            InitializeComponent();
            textName.Text = LoginControl.Instance.LoggedInMemberName;
            textTel.Text = LoginControl.Instance.LoggedInMemberTel;

        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            cityList = handler.GetCity();

            foreach (City city in cityList)
            {
                cbdepartureCity.Items.Add(city.CityName);
                cbArriveCity.Items.Add(city.CityName);
            }

            typeList = handler.GetTrainTypes();
            foreach (TrainType type in typeList)
            {
                cbTrainType.Items.Add(type.VehicleName);
            }

            listTrainSchedule.Columns.Add("열차 종류", 80, HorizontalAlignment.Center);
            listTrainSchedule.Columns.Add("출발역", 80, HorizontalAlignment.Center);
            listTrainSchedule.Columns.Add("출발 시간", 80, HorizontalAlignment.Center);
            listTrainSchedule.Columns.Add("도착역", 80, HorizontalAlignment.Center);
            listTrainSchedule.Columns.Add("도착 시간", 80, HorizontalAlignment.Center);
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            if(listTrainSchedule.SelectedItems.Count > 0)
            {
                TicketInfo ticket = new TicketInfo();
                ticket.Email = LoginControl.Instance.LoggedInMemberEmail;
                ListViewItem item = listTrainSchedule.SelectedItems[0];
                ticket.Ticket.TrainType = item.SubItems[0].Text;
                ticket.Ticket.DepartureStation = item.SubItems[1].Text;
                ticket.Ticket.DepartureTime = item.SubItems[2].Text;
                ticket.Ticket.ArriveStation = item.SubItems[3].Text;
                ticket.Ticket.ArriveTime = item.SubItems[4].Text;
                ticket.Ticket.Date = dtpDepartureDate.Value.ToString("yy.MM.dd");
                handler.SaveTicket(ticket);
                MessageBox.Show("열차 탑승권이 선택 되었습니다");
            }
            else
            {
                MessageBox.Show("예매할 열차 일정을 선택해주세요");
                return;
            }
            PayForm payForm = new PayForm();
            payForm.StartPosition = FormStartPosition.CenterScreen;
            payForm.Show();
            this.Close();
        }

        //열차 조회 -> 필요한 정보 다 입력되었는지 확인 후 결과 표시
        private async void btnTrainQuery_Click(object sender, EventArgs e)
        {
            if (cbdepartureCity.SelectedItem == null)
            {
                MessageBox.Show("출발 지역을 선택하세요");
                return;
            }
            if (cbDepartureStation.SelectedItem == null)
            {
                MessageBox.Show("출발역을 선택하세요");
                return;
            }
            if (cbArriveCity.SelectedItem == null)
            {
                MessageBox.Show("도착 지역을 선택하세요");
                return;
            }
            if (cbArriveStation.SelectedItem == null)
            {
                MessageBox.Show("도착역을 선택하세요");
                return;
            }
            if(cbTrainType.SelectedItem == null)
            {
                MessageBox.Show("열차 종류를 선택하세요");
                return;
            }

            string date = dtpDepartureDate.Value.ToString("yyyyMMdd");
            string checkedDate = "2023";
            if (int.Parse(dtpDepartureDate.Value.ToString("yyyyMM")) >= int.Parse(DateTime.Now.ToString("yyyyMM")))
                checkedDate += dtpDepartureDate.Value.ToString("MMdd");
            else
                checkedDate = date;

            TrainType trainType = typeList.Find(type => type.VehicleName == cbTrainType.Text);
            TrainStation departureStation = departureStationList.Find(station => station.NodeName == cbDepartureStation.Text);
            TrainStation arriveStation = arriveStationList.Find(station => station.NodeName == cbArriveStation.Text);

            List<TrainSchedule> trainSchedules = await TrainInfoApi.GetTrainScheduleAsync(departureStation.NodeId, arriveStation.NodeId, checkedDate, trainType.VehicleId);

            if (trainSchedules.Count!=0)
            {
                MessageBox.Show("조회 완료");
                listTrainSchedule.Items.Clear();
                foreach (TrainSchedule items in trainSchedules)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = items.TrainType;
                    item.SubItems.Add(items.DepartureStation);
                    item.SubItems.Add(items.DepartureTime.Substring(8, 2) + ":" + items.DepartureTime.Substring(10, 2));
                    item.SubItems.Add(items.ArriveStation);
                    item.SubItems.Add(items.ArriveTime.Substring(8, 2) + ":" + items.DepartureTime.Substring(10, 2));
                    listTrainSchedule.Items.Add(item);
                }
            }
            else
                MessageBox.Show("해당하는 운행 일정이 없습니다.");
        }

        //출발 지역 선택 -> 출발역 선택 활성화
        private void cbdepartureCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDepartureStation.Items.Clear();
            string selected = cbdepartureCity.SelectedItem.ToString();
            City foundCity = cityList.Find(city => city.CityName == selected);
            cbDepartureStation.Enabled = true;

            departureStationList = handler.GetTrainStation(foundCity.CityCode);
            foreach (TrainStation item in departureStationList)
            {
                cbDepartureStation.Items.Add(item.NodeName);
            }
        }
        //도착 지역 선택 -> 도착역 선택 활성화
        private void cbArriveCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbArriveStation.Items.Clear();
            string selected = cbArriveCity.SelectedItem.ToString();
            City foundCity = cityList.Find(city => city.CityName == selected);
            cbArriveStation.Enabled = true;

            arriveStationList = handler.GetTrainStation(foundCity.CityCode);
            foreach (TrainStation item in arriveStationList)
            {
                cbArriveStation.Items.Add(item.NodeName);
            }
        }
    }
}
