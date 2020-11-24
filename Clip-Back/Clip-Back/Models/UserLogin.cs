using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_Back.Models
{
    public class UserLogin
    {
        public UserLogin(string username, string token)
        {
            this.username = username;
            this.token = token;
        }

        public string username { get; set; }
        public string token { get; set; }
    }
}