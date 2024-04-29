namespace IsaacOkomanyi_ProfilePage.Models
{
    public class profile
    {

        public int Id { get; set; }
        public string FirstName { get; set; } // Added property for first name
        public string LastName { get; set; } // Added property for last name
        public string Email { get; set; } // Added property for email
        public string ProfilePhotoUrl { get; set; } // Added property for profile photo URL

        public profile() 
        {
               
        }
    }

}
