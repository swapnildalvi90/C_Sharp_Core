using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExtensionMethod
{
    public class Employee
    {
        private int _empId;
        private string _empName;
        private string _gender;

        public int EmpId
        {
            get
            {
                return _empId;
            }
            set
            {
                this._empId = value;
            }
        }

        public string EmpName
        {
            get
            {
                return _empName;
            }
            set
            {
                this._empName = value;
            }

        }

        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                this._gender = value;
            }
        }
        
        
    }
}