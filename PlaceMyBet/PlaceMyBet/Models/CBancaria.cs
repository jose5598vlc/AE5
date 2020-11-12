using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class CBancaria
    {
        

        
        public CBancaria(int CBancariaId, double saldoBanco, string nombreBanco, string numtarCredito, int UsuarioId)
        {
            this.CBancariaId = CBancariaId;
            this.saldoBanco = saldoBanco;
            this.nombreBanco = nombreBanco;
            this.numtarCredito = numtarCredito;
            this.UsuarioId = UsuarioId;
        }

        public int CBancariaId { get; set; }

        public double saldoBanco { get; set; }

        public string nombreBanco { get; set; }

        public string numtarCredito { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

    

    }
}