using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Restaurant
{
    internal class Employee
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public Employee(string _name, string _password)
        {
            Username = _name;
            Password = _password;
        }

        public bool  Equal(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Employee other = (Employee)obj;
            if (Username == other.Username && Password == other.Password)
                return true;
            return false;
        }
    

    }
    
}
