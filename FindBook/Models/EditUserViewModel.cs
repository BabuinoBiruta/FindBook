using System.Collections.Generic;

namespace FindBook.Models
{
    public class EditUserViewModel
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public List<string> AllRoles { get; set; } 
    }
}
