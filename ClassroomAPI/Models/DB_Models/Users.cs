﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassroomAPI.Models.DB_Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}