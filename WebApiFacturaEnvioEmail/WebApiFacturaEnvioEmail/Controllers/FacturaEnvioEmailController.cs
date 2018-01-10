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

        //POST: api/GetHDFactNotificacionEmail
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




    }
}
