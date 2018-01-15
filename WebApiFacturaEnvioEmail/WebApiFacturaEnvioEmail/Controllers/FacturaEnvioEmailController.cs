using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiFacturaEnvioEmail.Models;
using WebApiFacturaEnvioEmail.Services;


namespace WebApiFacturaEnvioEmail.Controllers
{
    public class FacturaEnvioEmailController : ApiController
    {

        //GET: api/GetHDFactNotificacionEmail
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetHDFactNotificacionEmail()
        {
            List<HDFactNotificacionEmail> respone = null;

            try
            {
                respone = DbServices.GetHDFactNotificacionEmail();
                   
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok(respone);

        }
        //
        //GET: api/GetHDFactNotificacionEmail
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetHDFactDetalleNotificacionEmail(string GkeyFact)
        {
            List<HDFactDetalleNotificacionEmail> respone = null;

            try
            {
                respone = DbServices.GetHDFactDetalleNotificacionEmail(GkeyFact);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok(respone);

        }
        //
        //POST: api/Create_Truck_Visit
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [System.Web.Http.HttpPost]
        public IHttpActionResult UpdateHDFactNotificacionEmailEnviada(int NumFactura)
        {
            ResponseMsg response = null;
            try
            {
                DbServices.UpdateHDFactNotificacionEmailEnviada(NumFactura);
                response = new ResponseMsg() { Status = "OK", Codigo = "0", Message = "" };

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok(response);
        }

    }
}
