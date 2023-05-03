using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JURNAL_KPL_MOD9_1302213015.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public static List<Movie> movieData = new List<Movie>
        {
            new Movie("The Shawshank Redemption (1994)", "Frank Darabont", new List<string>{" Tim Robbins"," Morgan Freeman", "Bob Gunton", "William Sadler" },"Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."),
            new Movie("The Godfather (1972) ", "Francis Ford Coppola", new List<string>{"  Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton Robbins" },"The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
             new Movie(" The Dark Knight (2008)", " Christopher Nolan ", new List<string>{"Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine" },"When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."),

        };

        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movieData;
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return movieData[id];
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            movieData.Add(value);
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Movie value)
        {
            movieData[id] = value;
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movieData.RemoveAt(id);
        }
    }
}
