using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PronosticoTiempo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmotionController : ControllerBase
    {
        [HttpGet]
        [Route("connumero")]
        public string Emocion(int suerte)
        {
            if (suerte == 0)
                return "sos una persona indiferente";
            if (suerte == 1)
                return "sos una persona feliz";
            if (suerte == 3)
                return "sos una persona aburrida";
            return "estoy muy ocupado no te puedo atender en este momento";
             
         }
         [HttpPost]
        [Route("connumero")]
        public string Emocion2 ([FromHeader] int suerte)
            {
            if (suerte == 0); 
                return "sos una persona indiferente";
            if (suerte == 1)
                return "sos una persona feliz";
            if (suerte == 3)
                return "sos una persona aburrida";
            return "estoy muy ocupado no te puedo atender en este momento";
             
         }
}
}
