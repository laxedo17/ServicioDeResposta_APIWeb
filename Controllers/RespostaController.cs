using Microsoft.AspNetCore.Mvc;

namespace RespostaService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RespostaController : ControllerBase
    {
        //GET /api/resposta/1 por exemplo, esta seria a ruta
        [Route("{id:int}")]
        [HttpGet]
        public ActionResult GetResposta(int id)
        {
            Random aleatorio = new Random();
            var aleatorioInteger = aleatorio.Next(1, 101); //devolvemos un numero aleatorio entre 1 e 101
            if (aleatorioInteger >= id)
            {
                Console.WriteLine("--> Fallo - Xenera resposta HTTP 500");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Console.WriteLine("--> Exito - Xenera resposta HTTP 200");
            return Ok();
        }
    }
}