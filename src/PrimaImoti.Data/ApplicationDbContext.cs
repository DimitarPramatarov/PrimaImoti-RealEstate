using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrimaImoti.DataModels;
using PrimaImoti.DataModels.Ad;
using PrimaImoti.DataModels.Estate;

namespace PrimaImoti.Data
{
    public class ApplicationDbContext : IdentityDbContext<PrimaImotiUser, IdentityRole, string>
    {
        public DbSet<EstateProperty> Estates { get; set; }

        public DbSet<Ad> Ads { get; set; }


        public DbSet<Person> Persons { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<EstateFeatures> EsteateFeatures {get; set;} 
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


    }
}
