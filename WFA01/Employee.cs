using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA01
{
    class Employee
    {
        private int _empID;
        private string _loginName;
        private string _password;
        private int _SSN;
        private string _department;
        private int _securityLevel;

        public int EmployeeID
        {
            get { return _empID; }
        }

        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public int SecurityLevel
        {
            get { return _securityLevel; }
        }

        private int GetNextID()
        {
            //simulates the retrieval of next
            //available id from database
            return 100;
        }

        public Employee()
        {
            _empID = GetNextID();
        }

        public Employee(int empID)
        {
            //Constructor for existing employee
            //Simulates retrieval from database
            if (empID == 1)
            {
                _empID = empID;
                LoginName = "smith";
                Password = "js";
                SSN = 123456789;
                Department = "IS";
            }
            else if (empID == 2)
            {
                _empID = empID;
                LoginName = "jones";
                Password = "mj";
                SSN = 987654321;
                Department = "HR";
            }
            else
            {
                throw new Exception("Invalid Employee ID");
            }
        }
        
        public string Update(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
            return "Security info updated.";
        }

        public string Update(int ssNumber, string department)
        {
            SSN = ssNumber;
            Department = department;
            return "HR info updated.";
        }

        public Boolean Login(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
            
            //Data normally retrieved from database.
            //Hard coded for demo only.
            if (loginName == "smith" & password == "js")
            {
                _empID = 1;
                _securityLevel = 2;
                return true;
            }
            else if (loginName == "jones" & password == "mj")
            {
                _empID = 2;
                _securityLevel = 4;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
