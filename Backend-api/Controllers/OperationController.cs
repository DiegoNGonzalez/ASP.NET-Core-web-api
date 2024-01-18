using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        [HttpGet]
        public decimal Get(decimal a, decimal b)
        {
            return a + b;
        }

        [HttpPost]
        public decimal Add( Numbers numbers)
        {
            return numbers.a - numbers.b;
        }
        [HttpPut]
        public decimal Edit(decimal a, decimal b)
        {
            return a *b;
        }
        [HttpDelete]
        public decimal Delete(decimal a, decimal b)
        {
            return a / b;
        }
    }

    public class  Numbers
    {
        public decimal a { get; set; }
        public decimal b { get; set; }
        
    }
}
