using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Evento
    {



        public Evento(int EventoId, string equipoLocal, string equipoVisitante, string fecha)
        {
            this.EventoId = EventoId;
            this.equipoLocal = equipoLocal;
            this.equipoVisitante = equipoVisitante;
            this.fecha = fecha;
        }

        public int EventoId { get; set; }
        public string equipoLocal { get; set; }

        public string equipoVisitante { get; set; }

        public string fecha { get; set; }

        public List<Mercado> Mercados { get; set; }

    }


    public class EventoDTO
    {
        public EventoDTO(string equipoLocal, string equipoVisitante)
        {

            this.equipoLocal = equipoLocal;
            this.equipoVisitante = equipoVisitante;

        }


        public string equipoLocal { get; set; }

        public string equipoVisitante { get; set; }





    }

    //ejercicio 2 examen
    public class EventosExamen {

        public EventosExamen(string equipoLocal, string equipoVisitante, double tipoMercado, double infocuotaOver, double infocuotaUnder, double dineroapostadoOver, double dineroapostadoUnder)
        {
            this.equipoLocal = equipoLocal;
            this.equipoVisitante = equipoVisitante;
            this.tipoMercado = tipoMercado;
            this.infocuotaOver = infocuotaOver;
            this.infocuotaUnder = infocuotaUnder;
            this.dineroapostadoOver = dineroapostadoOver;
            this.dineroapostadoUnder = dineroapostadoUnder;

        }

        public string equipoLocal { get; set; }
        public string equipoVisitante { get; set; }
       

        public double tipoMercado { get; set; }

        public double infocuotaOver { get; set; }

        public double infocuotaUnder { get; set; }

        public double dineroapostadoOver { get; set; }

        public double dineroapostadoUnder { get; set; }



    }

     



    
}