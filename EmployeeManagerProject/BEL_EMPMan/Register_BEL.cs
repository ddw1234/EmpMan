using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL_EMPMan
{
    public class Register_BEL
    {
        private string username = "";
        private string password = "";
        private string firstname = "";

        public string USERNAME
        {
            get
            { return username; }

            set
            { username = value; }
        }

        public string PASSWORD
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string FIRSTNAME
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
    }
}
