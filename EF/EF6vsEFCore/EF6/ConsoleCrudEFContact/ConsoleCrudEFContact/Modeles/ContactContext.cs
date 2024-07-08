using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCrudEFContact.Modeles
{
    internal class ContactContext : DbContext
    {
        public ContactContext() : base("name=ContactDbConnectionString")
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
