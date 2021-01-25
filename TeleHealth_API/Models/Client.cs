using System.ComponentModel.DataAnnotations;
using System;

/*
    Client Model

    Description: Contains all the fields pretaining the client information that an
                 employee will record and submit through the Windows Form Application.

                 Required fields currently include the clients First and Last name, 
                 their postal code, and the Concerns and Response field. Additional 
                 optional fields include the clients middle name(s), their addresses, 
                 province, city and phone number.
*/
public class Client
{
    public Guid ID { get; set; }
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Display(Name = "Middle Name")]
    public string MiddleName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [DataType(DataType.PhoneNumber)]
    [RegularExpression(@"^(\(?)([0-9]{3})(\)?)[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string Province { get; set; }

    [Required]
    [RegularExpression(@"^([a-z,A-Z]{1})([0-9]{1})([a-z,A-Z]{1})[ ]?([0-9]{1})([a-z,A-Z]{1})([0-9]{1})$", ErrorMessage = "Not a valid phone number")]
    [Display(Name = "Postal Code")]
    public string PostalCode { get; set; }

    [Required]
    [StringLength(200)]
    public string Concerns { get; set; }

    [Required]
    [StringLength(200)]
    public string Response { get; set; }

}