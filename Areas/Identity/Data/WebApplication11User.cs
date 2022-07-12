using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication11.Areas.Identity.Data;

// Add profile data for application users by adding properties to the WebApplication11User class
public class WebApplication11User : IdentityUser
{
    public int First_Name { get; set; }
    public int Last_Name { get; set; }
}

