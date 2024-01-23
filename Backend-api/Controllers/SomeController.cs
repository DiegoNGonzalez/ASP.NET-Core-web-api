using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Backend_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomeController : ControllerBase
    {
        [HttpGet("sync")]

        public IActionResult GetSync() 
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            Thread.Sleep(1000);
            Console.WriteLine("Conexion a base de datos terminada");

            Thread.Sleep(1000);
            Console.WriteLine("Envio de mail terminado");

            Console.WriteLine("Todo ha terminado");
            sw.Stop();
            return Ok(sw.Elapsed);
        }

        [HttpGet("async")]

        public async Task<IActionResult> GetAsync()
        {
            var task1 = new Task<int>(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Conexion a base de datos terminada");
                return 9;
            });

            task1.Start();

            Console.WriteLine("hago otra cosa");

            var result =await task1;

            Console.WriteLine("Todo ha terminado");

            return Ok(result);
        }
    }
}
