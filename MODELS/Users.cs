using System;
using System.Collections.Generic;
using System.Text;

namespace MODELS
{
    class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string ContactNumber { get; set; }
        public string Profile { get; set; }
        public string Image { get; set; }
    }
}
