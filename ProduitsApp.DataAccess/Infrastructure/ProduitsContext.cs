using ProduitsApp.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduitsApp.DataAccess.Infrastructure
{
    public class ProduitsContext : DbContext
    {
        public ProduitsContext():base("name=MyDB")
        {

        }
        public DbSet<Produit> Produits { get; set; }
    }
}
