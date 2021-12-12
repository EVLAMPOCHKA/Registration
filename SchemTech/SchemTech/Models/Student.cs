using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemTech.Models
{
    public class Student : IdentityUser
    {
       public int Group { get; set; }
       public double Mark { get; set; }
    }
}
