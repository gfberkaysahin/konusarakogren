using Microsoft.AspNetCore.Identity;

namespace EntityLayer;

public class ApplicationUser:IdentityUser
{
    public string NameSurname { get; set; }
    
}