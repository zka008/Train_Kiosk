using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using kiosk;
using kiosk.DTO;
using System.Collections;

namespace kiosk.DataBase
{

    public class MySQLHandler
    {
        private string connectionString;

        //인스턴스 생성 시 DB 연결 주소 생성
        public MySQLHandler()
        {
            string server = "a";
            string port = "a";
            string database = "a";
            string id = "a";
            string pw = "a";
            connectionString = $"a";
        }

        // 회원가입 - 이메일, 비밀번호, 이름, 전화번호, 주민번호
        public bool RegisterMember(string email, string password, string name, string tel, string identificationNumber)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO MemberInfo (email, password, name, tel,identificationNumber) VALUES (@email, @password, @name, @tel, @identificationNumber)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@tel", tel);
                    command.Parameters.AddWithValue("@identificationNumber", identificationNumber);

                    int rowsAffected = command.ExecuteNonQuery(); //DB 변경된 부분의 수

                    return rowsAffected > 0;
                }
            }
        }

        // 회원탈퇴 -  이메일
        public bool UnregisterMember(string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM MemberInfo WHERE email = @email";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        //로그인 - 정보 조회
        public bool LoginMember(string email, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM MemberInfo WHERE email = @email AND password = @password";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    // ExecuteScalar를 사용하여 결과를 가져옴
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // count가 1이면 일치하는 정보가 있음, 그렇지 않으면 없음
                    return count == 1;
                }
            }
        }
        
        //티켓 정보 저장
        public bool SaveTicket(TicketInfo ticket)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Ticket (email, trainType, departureStation, departureTime, arriveStation, arriveTime, date) VALUES (@email, @trainType, @departureStation, @departureTime, @departureStation, @arriveTime, @date)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", ticket.Email);                    
                    command.Parameters.AddWithValue("@trainType", ticket.Ticket.TrainType);
                    command.Parameters.AddWithValue("@departureStation", ticket.Ticket.DepartureStation);
                    command.Parameters.AddWithValue("@departureTime", ticket.Ticket.DepartureTime);
                    command.Parameters.AddWithValue("@arriveStation", ticket.Ticket.ArriveStation);
                    command.Parameters.AddWithValue("@arriveTime", ticket.Ticket.ArriveTime);
                    command.Parameters.AddWithValue("@date", ticket.Ticket.Date);

                    int rowsAffected = command.ExecuteNonQuery(); //DB 변경된 부분의 수

                    return rowsAffected > 0;
                }
            }
        }

        //티켓 조회
        public List<TicketInfo> GetTicket(string email) {
            List<TicketInfo> ticket = new List<TicketInfo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Ticket WHERE email = @email ORDER BY date";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string trainType = reader["trainType"].ToString();
                            string departureStation = reader["departureStation"].ToString();
                            string departureTime = reader["departureTime"].ToString();
                            string arriveStation = reader["arriveStation"].ToString();
                            string arriveTime = reader["arriveTime"].ToString();
                            string date = reader["date"].ToString();

                            ticket.Add(new TicketInfo(email, trainType, departureStation, departureTime, arriveStation, arriveTime, date));
                        }
                    }
                }
            }
            return ticket;
        }

        //로그인한 회원의 이름과 전화번호 반환
        public List<LoginMember> GetMemberInfo(string email)
        {
            List<LoginMember> loginMembers = new List<LoginMember>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name, tel FROM MemberInfo WHERE email = @email";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["name"].ToString();
                            string tel = reader["tel"].ToString();

                            loginMembers.Add(new LoginMember(name, tel));
                        }
                    }
                }
            }
            return loginMembers;
        }


        //기차 타입 조회
        internal List<TrainType> GetTrainTypes()
        {
            List<TrainType> trainTypes = new List<TrainType>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TrainType";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string vehicleId = reader["vehicleId"].ToString();
                            string vehicleName = reader["vehicleName"].ToString();

                            trainTypes.Add(new TrainType(vehicleId, vehicleName));
                        }
                    }
                }
            }
            return trainTypes;
        }

        //도시 코드, 도시 명 조회
        public List<City> GetCity()
        {
            List<City> cities = new List<City>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM City";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string cityCode = reader["cityCode"].ToString();
                            string cityName = reader["cityName"].ToString();

                            cities.Add(new City(cityCode, cityName));
                        }
                    }
                }
            }
            return cities;
        }

        //도시 별 기차역 조회
        public List<TrainStation> GetTrainStation(string cityCode)
        {
            List<TrainStation> trainStations = new List<TrainStation>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT nodeId, nodeName FROM TrainStation WHERE cityCode = @cityCode";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cityCode", cityCode);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nodeId = reader["nodeId"].ToString();
                            string nodeName = reader["nodeName"].ToString();

                            // Corrected the class constructor to initialize CityCode
                            trainStations.Add(new TrainStation(nodeId, nodeName, cityCode));
                        }
                    }
                }
            }
            return trainStations;
        }
    }
}