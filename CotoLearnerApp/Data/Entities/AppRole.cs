using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CotoLearnerApp.Data.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public AppRole() {}
        public AppRole(string name)
        {
            Name = name;
        }
    }
}