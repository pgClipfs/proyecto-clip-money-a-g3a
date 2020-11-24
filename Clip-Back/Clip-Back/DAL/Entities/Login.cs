using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.DAL.Entities
{
    public class Login
    {
        public Login() 
        {

        }

        public Login(Models.Login Login)
        {
            Username = Login.Username;
            Password = Login.Password;
        }

        [Key]
        public string Username { get; set; }

        public string Password { get; set; }


    }
}