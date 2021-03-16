using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Plataforma.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the PlataformaUser class
    public class PlataformaUser : IdentityUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Access { get; set; }
    }
}
