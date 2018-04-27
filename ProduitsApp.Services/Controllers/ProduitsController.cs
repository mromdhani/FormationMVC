using ProduitsApp.DataAccess.Domain;
using ProduitsApp.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProduitsApp.Services.Controllers
{
    public class ProduitsController : ApiController
    {
        private IProduitsRepository repo =
                new ProduitsRepositoryImpl();

        // GET: api/Produits
        public IEnumerable<Produit> Get()
        {
            return repo.FindAll();
        }

        // GET: api/Produits/5
        public Produit Get(string id)
        {
            return repo.FindById(id);
        }

        // POST: api/Produits
        public void Post(Produit p)
        {
            repo.Create(p);
        }

        // PUT: api/Produits/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Produits/5
        public void Delete(int id)
        {
        }
    }
}
