using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiFacturaEnvioEmail.Models
{
    public class HDFactNotificacionEmail
    {

        public string Gkey { get; set; }
        public string NumFactura { get; set; }
        public string NCF { get; set; }
        public string TipoFactura { get; set; }
        public string TipoPago { get; set; }
        public string FechaFacturado { get; set; }
        public string MontoRecibido { get; set; }
        public string RNC { get; set; }
        public string NumCliente { get; set; }
        public string Cliente { get; set; }
        public string NombreContacto { get; set; }
        public string Direccion { get; set; }
        public string CodigoEmail { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Observacion { get; set; }
        public string NombreUsuario { get; set; }
        
    }
    
}