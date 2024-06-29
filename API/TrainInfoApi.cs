using kiosk.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

// https://www.data.go.kr/iim/api/selectAPIAcountView.do
namespace kiosk.API
{
    internal class TrainInfoApi
    {
        static string serviceKey = "serviceKey";
        public static async Task<List<TrainSchedule>> GetTrainScheduleAsync(string departureStation, string arriveStation, string departureDate, string trainType)
        {
            string query = $"https://apis.data.go.kr/1613000/TrainInfoService/getStrtpntAlocFndTrainInfo?" +
                $"serviceKey={serviceKey}" +
                $"&pageNo=1" +
                $"&numOfRows=200" +
                $"&_type=xml" +
                $"&depPlaceId={departureStation}" +
                $"&arrPlaceId={arriveStation}" +
                $"&depPlandTime={departureDate}" +
                $"&trainGradeCode={trainType}";

            try
            {
                using (var client = new WebClient())
                {
                    string results = await client.DownloadStringTaskAsync(query);

                    List<TrainSchedule> trainScheduleList = ParseXmlData(results);

                    return trainScheduleList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류: {ex.Message}");
                return null;
            }
        }

        static List<TrainSchedule> ParseXmlData(string xmlData)
        {
            XDocument xmlDoc = XDocument.Parse(xmlData);

            var trainSheduleList = xmlDoc.Descendants("item")
                .Select(item => new TrainSchedule
                {
                    ArriveStation = item.Element("arrplacename").Value,
                    ArriveTime = item.Element("arrplandtime").Value,

                    DepartureStation = item.Element("depplacename").Value,
                    DepartureTime = item.Element("depplandtime").Value,

                    TrainType = item.Element("traingradename").Value
                }).ToList();
            return trainSheduleList;
        }
    }
}