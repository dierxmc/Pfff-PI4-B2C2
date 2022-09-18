using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Pfff_PI4_B2C2.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Pfff_PI4_B2C2User class
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
}

