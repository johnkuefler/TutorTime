using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TutorTime.Models;

namespace TutorTime.Controllers.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorsController : Controller
    {
        private readonly TutorDbContext _context;

        public TutorsController(TutorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllTutors()
        {
            return Ok(_context.Tutors.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_context.Tutors.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        public IActionResult CreateTutor([FromBody]Tutor tut)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Tutors.Add(tut);
            _context.SaveChanges();

            return Ok(tut);
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateTutor([FromRoute]int id, [FromBody]Tutor tut)
        {
            if (id != tut.Id)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.Tutors.Update(tut);
            _context.SaveChanges();

            return Ok(tut);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTutor([FromRoute]int id)
        {
            Tutor tut = _context.Tutors.FirstOrDefault( x=> x.Id == id);

            if (tut != null)
            {
                _context.Tutors.Remove(tut);
                _context.SaveChanges();
            }

            return Ok();
        }
    }
}
