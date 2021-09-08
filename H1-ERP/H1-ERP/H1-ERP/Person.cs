using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ERP
{
    class Person
    {
        private string userName, password;

        public string UserName
        {
            get
            {
                return userName;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(userName))
                {
                    userName = value;
                }
            }
        }

        public string Password
        {
            get { return password; }
            protected set 
            { 
                if (string.IsNullOrWhiteSpace(password))
                {
                    password = value;
                }
                else if (value == password)
                {
                    Console.WriteLine("Successfully logged in");
                }
                else
                {
                    Console.WriteLine("You typed something wrong");
                }
            }
        }
    }
}
