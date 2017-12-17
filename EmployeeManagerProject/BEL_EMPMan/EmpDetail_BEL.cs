using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL_EMPMan
{
   public class EmpDetail_BEL
    {
        public int UserID { get; set; }
        private string firstname;
        private string middlename;
        private string lastname;
        private string address;
        private string city;
        private string gender;
        private string emailid;
        private string empstatus;
        private int deptid;
        private string emptype;
        private string dateofbirth;
        private string dateofjoin;
        private int empid;

        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middlename;
            }
            set
            {
                middlename = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public string Emailid
        {
            get
            {
                return emailid;
            }
            set
            {
                emailid = value;
            }
        }
        public string EmpStatus
        {
            get
            {
                return empstatus;
            }
            set
            {
                empstatus = value;
            }
        }
        public int DeptID
        {
            get
            {
                return deptid;
            }
            set
            {
                deptid = value;
            }

        }
        public string EmpType
        {
            get
            {
                return emptype;
            }
            set
            {
                emptype = value;
            }
        }
        public string DateOfBirth
        {
            get
            {
                return dateofbirth;
            }
            set
            {
                dateofbirth = value;
            }
        }
        public string DateofJoin
        {
            get
            {
                return dateofjoin;
            }
            set
            {
                dateofjoin = value;
            }
        }
        public int EmpId
        {
            get
            {
                return empid;
            }
            set
            {
                empid = value;
            }
        }
    }
}
