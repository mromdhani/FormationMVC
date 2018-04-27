using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication5_Rest_Hello.Models;

namespace WebApplication5_Rest_Hello.Controllers
{
    public class ValuesController : ApiController
    {
        private static List<Produit> data = new List<Produit>()
            {
                new Produit{ Id=100, Nom="Souris Optique", PrixUnitaire=10.5M},
                new Produit{ Id=200, Nom="Clavier AZERTY", PrixUnitaire=20.5M},
                new Produit { Id = 300, Nom = "Flash USB 8Go", PrixUnitaire = 15.5M }
            };

        // GET api/values
        public IEnumerable<Produit> Get()
        {
            return data;
            
        }

        // GET api/values/5
        public Produit Get(int id)
        {
            return data.Where(p => p.Id.Equals(id)).FirstOrDefault();
        }

        // POST api/values
        public void Post(Produit p) 
        {
            data.Add(p);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
