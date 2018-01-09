using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiFacturaEnvioEmail.Models
{
    public class HDFactDetalleNotificacionEmail
    {
        public string Gkey { get; set; }
        public string GkeyFact { get; set; }
        public string UnitNbr { get; set; }
        public string SubTotal { get; set; }
        public string Tasa { get; set; }
        public string Tarifa { get; set; }
        public string Tarifa_Us { get; set; }
        public string Valor_Us { get; set; }
        public string Dia { get; set; }
        public string Valor_Rd { get; set; }
        public string Itbis { get; set; }
        public string Total_Rd { get; set; }
        
    }
}