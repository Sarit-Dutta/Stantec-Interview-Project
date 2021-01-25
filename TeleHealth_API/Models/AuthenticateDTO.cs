using System.ComponentModel.DataAnnotations;

/*
    AuthenticateDTO

    Description: DTO that returns role upon authentication which is used
                 to determine access level within the Web Client.
*/
public class AuthenticateDTO
{
    [Required]
    [Display(Name = "Role")]
    public string role { get; set; }
}