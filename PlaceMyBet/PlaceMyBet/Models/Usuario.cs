using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Usuario
    {
        
        public Usuario(int UsuarioId, string Email, string Nombre, string Apellidos, int Edad)
        {
            this.UsuarioId = UsuarioId;
            this.Email = Email;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
        }

        public int UsuarioId { get; set; }

        public string Email { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public int Edad { get; set; }

        public CBancaria CBancaria { get; set; }

        

    

        
    }
}