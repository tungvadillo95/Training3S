﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Domain.DTOs.Respone.User
{
    public class UserDetail
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
    }
}
