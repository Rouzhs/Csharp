﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public User() {
            
        }
        public User(string name, string password, string role)
        {
            Login = name;
            Password = password;    
            Role = role;    
        }
    }
}
