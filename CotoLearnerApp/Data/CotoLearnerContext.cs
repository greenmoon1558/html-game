using CotoLearnerApp.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CotoLearnerApp.Data
{
    public class CotoLearnerContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public CotoLearnerContext(DbContextOptions<CotoLearnerContext> options) : base(options)
        {} 
    }
}