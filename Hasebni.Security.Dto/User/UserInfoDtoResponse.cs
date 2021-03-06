﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hasebni.Security.Dto.User
{
    public class UserInfoDtoResponse
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Gender { get; set; }
        public int Avatar { get; set; }
        public string BirthDate { get; set; }

    }
}
