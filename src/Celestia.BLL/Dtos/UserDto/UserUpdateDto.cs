﻿
namespace Celestia.BLL.Dtos.UserDto
{
    public class UserUpdateDto
    {
        public string Username { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Salt { get; set; }

        public string Password { get; set; }
    }
}
