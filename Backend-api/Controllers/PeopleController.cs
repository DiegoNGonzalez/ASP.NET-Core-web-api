using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet("all")]
        public List<People> GetPeople() => Repository.People;
        [HttpGet("{id}")]
        public ActionResult<People> Get(int id)
        {
            var people = Repository.People.FirstOrDefault(p => p.Id == id);
            if (people == null)
            {
                return NotFound();
            }
            return Ok(people);
        }
        [HttpGet("search/{search}")]
        public List<People> Get(string search) =>
            Repository.People.Where(p => p.Name.ToUpper().Contains(search.ToUpper())).ToList();

        [HttpPost]
        public IActionResult Add(People people)
        {
            if(string.IsNullOrEmpty(people.Name))
            {
                return BadRequest();
            }
            Repository.People.Add(people);

            return NoContent();
        }
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
    }

    public class Repository
    {
        public static List<People> People = new List<People>()
        {
            new People(){Id = 1, Name = "John", Birthdate = new DateTime(1990, 1, 1)},
            new People(){Id = 2, Name = "Mary", Birthdate = new DateTime(1991, 1, 1)},
            new People(){Id = 3, Name = "Peter", Birthdate = new DateTime(1992, 1, 1)},
            new People(){Id = 4, Name = "Paul", Birthdate = new DateTime(1993, 1, 1)},
            new People(){Id = 5, Name = "Mark", Birthdate = new DateTime(1994, 1, 1)},
            new People(){Id = 6, Name = "Luke", Birthdate = new DateTime(1995, 1, 1)},
            new People(){Id = 7, Name = "James", Birthdate = new DateTime(1996, 1, 1)},
            new People(){Id = 8, Name = "Jude", Birthdate = new DateTime(1997, 1, 1)},
            new People(){Id = 9, Name = "Thomas", Birthdate = new DateTime(1998, 1, 1)},
            new People(){Id = 10, Name = "Andrew", Birthdate = new DateTime(1999, 1, 1)},
        };
    }
}
