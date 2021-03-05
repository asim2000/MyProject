﻿using Core.Entities.Abstract;

namespace Entity.DTOs
{
    public class UserForRegisterDto : IDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
