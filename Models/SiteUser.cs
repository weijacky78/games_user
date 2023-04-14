using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rp_ef_maria.Models;

public class SiteUser
{
    public uint SiteUserId { get; set; }

    [MaxLength(32, ErrorMessage = "Username must be 32 characters or less")]
    [Display(Name = "Username")]
    public string Username { get; set; } = "";

    [EmailAddress]
    [Display(Name = "Email Address")]
    public string Email { get; set; } = "";

    [Phone]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; } = "";

    [Display(Name = "Mailing Address")]
    public string MailingAddress { get; set; } = "";

    [Display(Name = "Proper Name")]
    public string FirstName { get; set; } = "";

    [Display(Name = "Family Name")]

    public string LastName { get; set; } = default!;

}