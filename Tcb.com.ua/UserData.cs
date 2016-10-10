using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tcb.com.ua
{
    public class UserData
    {
        public UserData(string email, string pass)
        {
            this.email = email;
            this.pass = pass;
        }

        public String email;
        public String pass;

        public UserData(string phone, string surname, string name, string fatherName, string dateOfBirth)
        {
            this.phone = phone;
            this.surname = surname;
            this.name = name;
            this.fatherName = fatherName;
            this.dateOfBirth = dateOfBirth;
        }

        public String phone;
        public String surname;
        public String name;
        public String fatherName;
        public String dateOfBirth;

    }
}
