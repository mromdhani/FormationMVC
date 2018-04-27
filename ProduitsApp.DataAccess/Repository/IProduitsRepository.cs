using ProduitsApp.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduitsApp.DataAccess.Repository
{
    public interface IProduitsRepository
    {
        // CRUD
        void Create(Produit p);    // C du CRUD
        IList<Produit> FindAll();  // R
        Produit FindById(string id);  // R
        Produit Update(Produit p); // U
        void delete(string id);  // D



    }
}
