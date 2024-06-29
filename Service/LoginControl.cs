using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kiosk.DataBase;
using kiosk.DTO;
using static System.Net.Mime.MediaTypeNames;

namespace kiosk.Service
{
    public class LoginControl
    {
        static LoginControl instance;
        MySQLHandler handler = new MySQLHandler();

        public static LoginControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginControl();
                }
                return instance;
            }
        }
        public string LoggedInMemberName { get; private set; }
        public string LoggedInMemberEmail { get; private set; }
        public string LoggedInMemberTel { get; private set; }

        public bool Login(string email, string password)
        {
            if (handler.LoginMember(email, password))
            {
                LoggedInMemberEmail = email;
                List<LoginMember> member = handler.GetMemberInfo(LoggedInMemberEmail);
                LoggedInMemberName = member[0].Name;
                LoggedInMemberTel = member[0].Tel;
                return true;
            }
            else
                return false;
        }
        public void Logout()
        {
            LoggedInMemberEmail = null;
        }
    }
}
