using System.ComponentModel.DataAnnotations;

/*
    UserDTO

    Description: This DTO was originally used to define the response format for
                 the get Users API endpoint defined in the User Controller.
*/
public class UserDTO
{
    [Display(Name = "Username")]
    public string userName { get; set; }

}