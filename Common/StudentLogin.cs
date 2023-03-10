using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Common
{
        [Serializable]
    public class StudentLogin
    {
        public StudentLogin(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public string id { set; get; }
        public string name { set; get; }
    }
}