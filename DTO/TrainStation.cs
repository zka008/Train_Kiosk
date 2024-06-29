using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk.DTO
{
    public class TrainStation
    {
        public string NodeId { get; set; }
        public string NodeName { get; set; }
        public string CityCode { get; set; }
        public TrainStation(string nodeId, string nodeName, string cityCode)
        {
            NodeId = nodeId;
            NodeName = nodeName;
            CityCode = cityCode;
        }
    }
}
