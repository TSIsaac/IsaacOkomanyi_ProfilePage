using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsaacOkomanyi_ProfilePage.Models
{
    public class User : IdentityUser<int> // Inherits from IdentityUser<T> where T is the type of the Id
    {
        public string Id { get; set; }
        [DisplayName("Full Name")]
        public string Name { get; set; }
        [DisplayName("Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [DataType(dataType: DataType.EmailAddress)]
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }
        public User() 
        {

        }
    }
}
