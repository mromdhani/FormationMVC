using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduitsApp.DataAccess.Domain
{
    public class Produit
    {
       
        public string Id { get; set; }
        public string Libelle { get; set; }
        public decimal PrixUnitaire { get; set; }
       

    }
}
