using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk.DTO
{
    public class TrainType
    {
        public string VehicleId { get; set; }
        public string VehicleName { get; set; }

        public TrainType(string vehicleId, string vehicleName)
        {
            VehicleId = vehicleId;
            VehicleName = vehicleName;
        }
    }
}
