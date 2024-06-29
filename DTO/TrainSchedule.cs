using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kiosk.DTO
{
    public class TrainSchedule
    {
        public string TrainType { get; set; }
        public string DepartureStation { get; set; }
        public string DepartureTime { get; set; }
        public string ArriveStation { get; set; }
        public string ArriveTime { get; set; }
        public string Date {  get; set; }
    }
}
