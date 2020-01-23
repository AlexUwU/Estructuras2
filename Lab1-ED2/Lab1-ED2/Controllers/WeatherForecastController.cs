using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1_ED2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lab1_ED2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody]Pelicula mpelicula)
        {
            if (Data.Instance.Peliculas.Count <= 9)
            {
                Data.Instance.Peliculas.Add(mpelicula);
            }
            else
            {
                Data.Instance.Peliculas.Reverse();
                Data.Instance.Peliculas.RemoveAt(0);
                Data.Instance.Peliculas.Add(mpelicula);
                
            }
        }


        [HttpGet]
        public List<Pelicula> Get()
        {
            Data.Instance.Peliculas.Reverse();
            return Data.Instance.Peliculas;
        }
    }
}
