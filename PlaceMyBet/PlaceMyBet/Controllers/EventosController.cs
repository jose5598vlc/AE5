using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class EventosController : ApiController
    {
        // GET: api/Eventos
        public IEnumerable<EventoDTO> Get()
        {
            
            var repo = new EventoRepository();
            /*
            List<Evento> evento = repo.Retrieve();
            */
            List<EventoDTO> eventos = repo.RetrieveDTO();
            return eventos;
        }

        // GET: api/Eventos/5
        public Evento Get(int id)
        {
            /*
            var repo = new EventoRepository();
            Evento e = repo.Retrieve();
            return e;
            */
            return null;
        }
        /*
        // GET: api/EventosExamen?val={nombre}

            public EventosExamen Retrieve(Evento e)
        {
            List<EventosExamen> eventos = new List<EventosExamen>();
            return eventos;
        }
        */
        // POST: api/Eventos
        public void Post([FromBody]string value)
        {
        }

        // ejercicio 2 examen controller
        // POST: api/EventosExamen

            public void Post([FromBody] EventosExamen examen)
        {
            var repo = new EventoRepository();
            repo.SaveEventosExamen(examen);
        }

        // PUT: api/Eventos/5
        public void Put(int id, [FromBody]EventoDTO eventos)
        {
            var repo = new EventoRepository();
            repo.update(id, eventos);
            
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
        }
    }
}
