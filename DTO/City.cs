using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk.DTO
{
    public class City
    {
        
        public string CityCode {  get; set; }
        public string CityName { get; set; }
        public City(string cityCode, string cityName)
        {
            CityCode = cityCode;
            CityName = cityName;
        }
    }
}
