using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modul8_1302204063.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public static List<string> stars1 = new List<string>() { "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler" };
        public static List<string> stars2 = new List<string>() { "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton" };
        public static List<string> stars3 = new List<string>() { "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine" };

        public static List<Movie> movies = new List<Movie>()
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", stars1,
                "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
            new Movie("The Godfather", "Francis Ford Coppola", stars2,
                "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movie("The Dark Knight", "Christopher Nolan", stars3,
                "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."),
        };
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return movies[id];
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            movies.Add(value);
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movies.RemoveAt(id);
        }
    }
}
