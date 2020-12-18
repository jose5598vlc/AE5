using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Apuesta
    {
        public Apuesta(int ApuestaId, bool tipoApuesta, double cuota, double dineroApostado, string fecha, int MercadoId, string UsuarioId)
        {
            this.ApuestaId = ApuestaId;
            this.tipoApuesta = tipoApuesta;
            this.cuota = cuota;
            this.dineroApostado = dineroApostado;
            this.fecha = fecha;
            this.MercadoId = MercadoId;
            this.UsuarioId = UsuarioId;
        }

        public int ApuestaId { get; set; }

        public bool tipoApuesta { get; set; }

        public double cuota { get; set; }

        public double dineroApostado { get; set; }

        public string fecha { get; set; }


        public int MercadoId { get; set; }

        public string UsuarioId { get; set; }

        public Mercado Mercados { get; set; }

        public Usuario Usuarios { get; set; }
    }

    
    public class ApuestaDTO
    {
        public ApuestaDTO(string UsuarioId, Boolean tipoApuesta, double cuota, double dineroApostado)
        {
            this.UsuarioId = UsuarioId;
            this.tipoApuesta = tipoApuesta;
            this.cuota = cuota;
            this.dineroApostado = dineroApostado;
            
        }



       
        public string UsuarioId { get; set; }

        public Boolean tipoApuesta { get; set; }

        public double cuota { get; set; }


        public double dineroApostado { get; set; }

        
    }

    /*
    public class ApuestaUsuario
    {
        public ApuestaUsuario(Boolean tipoApuesta, double cuota, double dineroApostado, int idEvento)
        {
            this.tipoApuesta = tipoApuesta;
            this.cuota = cuota;
            this.dineroApostado = dineroApostado;
            this.idEvento = idEvento;

        }
        public Boolean tipoApuesta { get; set; }
        public double cuota { get; set; }
        public double dineroApostado { get; set; }
        public int idEvento { get; set; }

    }

    public class ApuestaMercado
    {
        public ApuestaMercado(double tipoMercado, Boolean tipoApuesta, double cuota, double dineroApostado, string email)
        {
            this.tipoMercado = tipoMercado;
            this.tipoApuesta = tipoApuesta;
            this.cuota = cuota;
            this.dineroApostado = dineroApostado;
            this.email = email;

        }

        
        public double tipoMercado { get; set; }
        public Boolean tipoApuesta { get; set; }
        public double cuota { get; set; }

        public double dineroApostado { get; set; }

        public string email { get; set; }
    }
    */


}