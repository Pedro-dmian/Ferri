using ferreteria.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ferreteria.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        [HttpGet]
        [Route("prueba")]
        public HttpResponseMessage prueba()
        {
            HttpResponseMessage message = new HttpResponseMessage();

            message.StatusCode = HttpStatusCode.BadRequest;

            message.Content = new ObjectContent<Response<bool>>(new Response<bool>()
            {
                Estatus = Estatus.Exito,
                Mensaje = "Todo correcto",
                MensajeTecnico = "Prueba de mensaje"
            }, Utiles.Formatter);

            return message;

        }
    }
}
