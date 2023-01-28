using MediaLibrary.Models;
using Microsoft.AspNetCore.Identity;

namespace MediaLibrary.Areas.Identity.Data;

// Add profile data for application users by adding properties to the MediaLibraryUser class
public class MediaLibraryUser : IdentityUser
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}

