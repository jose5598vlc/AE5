using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class EventoRepository
    {
        internal List<Evento> Retrieve()
        {
            List<Evento> eventos = new List<Evento>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.Eventos.ToList();
            }
            return eventos;
        }

        internal List<EventoDTO> RetrieveDTO()
        {
            List<EventoDTO> eventos = new List<EventoDTO>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.Eventos.Select(p => ToDTO(p)).ToList();

            }
            return eventos;
        }

        internal void Save(Evento e)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();

            context.Eventos.Add(e);
            context.SaveChanges();

        }

        public EventoDTO ToDTO(Evento e)
        {
            return new EventoDTO(e.equipoLocal, e.equipoVisitante);
        }

       
      

        // un evento que permita modificar nombre de equipos a partir del ID
        internal void update(int id, EventoDTO e)
        {
            Evento eventos;
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.Eventos
                    .Where(s => s.EventoId == id)
                    .FirstOrDefault();
                eventos.equipoLocal = e.equipoLocal;
                eventos.equipoVisitante = e.equipoVisitante;
                //actualiza 
                context.Eventos.Update(eventos);
                context.SaveChanges();
            }
        }

        // ejercicio 1 examen
        
        // Listado de todos los mercados de este evento, donde para cada mercado se muestre el identificador, la cuota over y la cuota under.
        

        internal List<EventosExamen> RetrieveEventosExamen()
        {
            
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
               
            }
            return null;
            
        }

        //ejercicio 2 examen 
        internal void SaveEventosExamen(EventosExamen examen)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            context.examen.Add(examen);
            context.SaveChanges();

        }
        
        
        // delete 


        //internal void delete(int id)
        // {

        //   PlaceMyBetContext context = new PlaceMyBetContext();


        // var Evento = new Evento { EventoId = id }; 


        // context.Eventos.Attach(Evento);
        // context.Eventos.Remove(Evento);
        // context.SaveChanges();
        //  }
        /*
        private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=placemybet;Uid=root;password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }

        internal List<Evento> Retrieve()
        {
            
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "Select * from evento";

            try
            {

                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                Evento e = null;
                List<Evento> eventos = new List<Evento>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetString(3));
                    e = new Evento(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3));
                    eventos.Add(e);
                }
                con.Close();
                return eventos;
            }
            catch (MySqlException c)
            {
                Debug.WriteLine("Se ha producido un error de conexion");
                
                return null;
            }
        }

        internal List<EventoDTO> RetrieveDTO()
        {
        
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "Select * from evento";

            try
            {

                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                EventoDTO e = null;
                List<EventoDTO> eventos = new List<EventoDTO>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetString(3));
                    e = new EventoDTO(res.GetString(1), res.GetString(2), res.GetString(3));
                    eventos.Add(e);
                }
                con.Close();
                return eventos;
            }
            catch (MySqlException c)
            {
                Debug.WriteLine("Se ha producido un error de conexion");
                
                return null;
            }
        }

    */

    }

}