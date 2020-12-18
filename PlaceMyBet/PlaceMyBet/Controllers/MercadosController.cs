﻿using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class MercadosController : ApiController
    {
        // GET: api/Mercados
        public IEnumerable<MercadoDTO> Get()
        {
            /*
            return new string[] { "value1", "value2" };
            */
            var repo = new MercadoRepository();
            /*
            List<Mercado> mercado = repo.Retrieve();
            */
            List<MercadoDTO> mercados = repo.RetrieveDTO();
            return mercados;
        }

        // GET: api/Mercados/5
        public Mercado Get(int id)
        {
            
            var repo = new MercadoRepository();
            Mercado m = repo.Retrieve(id);
            return m;
                       
        }

        // POST: api/Mercados
        public void Post([FromBody]Mercado mercados)
        {
            var repo = new MercadoRepository();
            repo.save(mercados);
        }
        

        // PUT: api/Mercados/5
        /*
        public void Put(int id, [FromBody]string value)
        {
        }
        */

        // DELETE: api/Mercados/5
        /*
        public void Delete(int id)
        {
        }
        */
    }
}
