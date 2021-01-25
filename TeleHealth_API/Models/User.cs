using System.ComponentModel.DataAnnotations;

namespace TeleHealth_API.Models
{
    /*
        User Model

        Description: Model used to define the data required for a user. Requirements include
                     the username and password. The additional data parameter role is used
                     by the web client to ensure that only supervisors and admins can access.
    */
    public class User
    {
        public long ID { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string userName { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Display(Name = "Role")]
        public string role { get; set; }
    }

}