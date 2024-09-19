using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApiSemana4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("DevolverValor")]
        public int DevolverValor()
        {
            int num1 = 8;
            int num2 = 5;
            int num3 = num1 - num2;
            num2 = num1 * num3;
            num3 = num2 + num1 * num2;
            num1 = num3 / num1;
            num2 = num1 % num2;
            return num3;

        }

        [HttpGet("DevolverSaludo")]
        public string DevolverSaludo()
        {
            string variable1 = "pedro";
            string variable2 = "juan";
            string variable3 = variable1 + variable2;
            int num1 = 7;
            string variable4 = variable3 + num1;
            string mensaje = "hola" + variable4;
            return mensaje;

        }

        [HttpGet("DevolverMayor/{num1}/{num2}")]
        public string DevolverMayor(int num1, int num2)
        {
            if ( num1 > num2)
            {
                return "El mayor es" + num1.ToString();
            }
            else
            {
                return "El mayor es" + num2.ToString();
            }

        }

        [HttpGet("DevolverEstado/{edad}/{Nombre}")]
        public string DevolverEstado(int edad, string Nombre)
        {
            string mensaje = "";
            if (edad >=18)
            {
               mensaje = "Sr(a)" + Nombre + " es mayor de edad";
            }
            else
            {
               mensaje = "Sr(a)" + Nombre + " es menor de edad";
            }
            return mensaje;

        }


        [HttpGet("DevolverEdad")] 
        public int DevolverEdad()
        {
            string mensaje = string.Empty;
            Alumno Alumno3 = new Alumno("Juan", "Perez", "4370258", new DateTime(2002, 10, 13));
            return Alumno3.DevolverEdad();
                
        }
    }
}   