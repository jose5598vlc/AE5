using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Mercado
    {

   
        public Mercado(int MercadoId, double tipoMercado, double infocuotaOver, double infocuotaUnder, double dineroapostadoOver, double dineroapostadoUnder, int EventoId)
        {
            this.MercadoId = MercadoId;
            this.tipoMercado = tipoMercado;
            this.infocuotaOver = infocuotaOver;
            this.infocuotaUnder = infocuotaUnder;
            this.dineroapostadoOver = dineroapostadoOver;
            this.dineroapostadoUnder = dineroapostadoUnder;
            this.EventoId = EventoId;
        }

        public int MercadoId { get; set; }

        public double tipoMercado { get; set; }
        public double infocuotaOver { get; set; }

        public double infocuotaUnder { get; set; }

        public double dineroapostadoOver { get; set; }

        public double dineroapostadoUnder { get; set; }

        public int EventoId { get; set; }

        public Evento Evento { get; set; }

        public List<Apuesta> Apuestas { get; set; }

    }
    /*
    public class MercadoDTO
    {
        public MercadoDTO(double tipoMercado, double infocuotaOver, double infocuotaUnder)
        {
            this.tipoMercado = tipoMercado;
            this.infocuotaOver = infocuotaOver;
            this.infocuotaUnder = infocuotaUnder;
            
        }

        public double tipoMercado { get; set; }
        public double infocuotaOver { get; set; }

        public double infocuotaUnder { get; set; }

        
    


    }
    */
}