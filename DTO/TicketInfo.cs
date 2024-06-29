using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk.DTO
{
    public class TicketInfo
    {
        //아이디, 이름, 전화번호, 티켓 정보
        public string Email {  get; set; }
        public TrainSchedule Ticket { get; set; }
        public TicketInfo() { 
            Ticket = new TrainSchedule();
        }
        public TicketInfo(string email, string trainType, string departureStation, string departureTime, string arriveStation, string arriveTime) {
            Ticket = new TrainSchedule();
            Email = email;
            Ticket.TrainType = trainType;
            Ticket.DepartureStation = departureStation;
            Ticket.DepartureTime = departureTime;
            Ticket.ArriveStation = arriveStation;
            Ticket.ArriveTime = arriveTime;
        }
        public TicketInfo(string email, string trainType, string departureStation, string departureTime, string arriveStation, string arriveTime, string date)
        {
            Ticket = new TrainSchedule();
            Email = email;
            Ticket.TrainType = trainType;
            Ticket.DepartureStation = departureStation;
            Ticket.DepartureTime = departureTime;
            Ticket.ArriveStation = arriveStation;
            Ticket.ArriveTime = arriveTime;
            Ticket.Date = date;
        }
    }
}
