using Microsoft.EntityFrameworkCore;
using ProjetoDecode.Domain.Entities;
using System;
using System.Drawing;
using System.Linq;

namespace ProjetoDecode.Infrastructure.Data.Context
{
    public class DecodeContext : DbContext
    {
        public DecodeContext()
        {

        }

        public DecodeContext(DbContextOptions<DecodeContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }

        public override int SaveChanges()
        {
            //For each interaction with database, verifies if there is a property named "RegisterDate"
            //If exists and it's an inclusion, sets de curremt Datetime. If exsists and itºs an update, doesn't update
            foreach(var entry in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("RegisterDate") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("RegisterDate").CurrentValue = DateTime.Now;
                if (entry.State == EntityState.Modified)
                    entry.Property("RegisterDate").IsModified = false;
            }
            
            return base.SaveChanges();
        }
    }
}
