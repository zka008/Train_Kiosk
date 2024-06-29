using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk.DTO
{
    public class LoginMember
    {
        public string Name { get; set; }
        public string Tel { get; set; }
        public LoginMember(string name, string tel) { 
            Name = name;
            Tel = tel;
        }
    }
}
