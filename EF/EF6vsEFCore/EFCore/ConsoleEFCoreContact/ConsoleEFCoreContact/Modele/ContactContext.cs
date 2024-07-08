using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConsoleEFCoreContact.Modele
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thboulan\OneDrive - Capgemini\Documents\JRI\TD\EF\EFCore\ConsoleEFCoreContact\ConsoleEFCoreContact\Data\DatabaseContactsEFCore.mdf;Integrated Security=True");
        }
    }
}
