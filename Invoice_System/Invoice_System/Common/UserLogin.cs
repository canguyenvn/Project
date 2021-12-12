using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Invoice_System.Common
{
    [Serializable]
    public class UserLogin
    {
        public long User_ID { set; get; }
        public string User_Password { set; get; }
    }
}