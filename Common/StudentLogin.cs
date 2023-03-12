using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Common
{
    //Serialization data => cbi cho việc object student login sẽ được trình tự hóa (serializable) để chuyền đi cho dễ
        [Serializable]
    public class StudentLogin
    {
        public string Username { set; get; }
        public string Password { set; get; }
        public StudentLogin(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
    }
}