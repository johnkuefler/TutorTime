using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TutorTime.Models;

namespace TutorTime.Controllers.APIs
{
    public class TutorsController : Controller
    {
        private readonly TutorDbContext _context;

        public TutorsController(TutorDbContext context)
        {
            _context = context;
        }

        [HttpGet("~/api/tutors")]
        public IActionResult GetAllTutors()
        {
            return Ok(_context.Tutors.ToList());
        }

        [HttpGet("~/api/tutors/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_context.Tutors.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost("~/api/tutors")]
        public IActionResult CreateTutor([FromBody]TutorViewModel tut)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Tutor newTutor = new Tutor
            {
                FirstName = tut.FirstName,
                LastName = tut.LastName,
                Location = tut.Location,
                Subject = tut.Subject,
            };

            _context.Tutors.Add(newTutor);
            _context.SaveChanges();

            return Ok(tut);
        }

        [HttpPatch("~/api/tutors/{id}")]
        public IActionResult UpdateTutor([FromRoute]int id, [FromBody]TutorViewModel tut)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Tutor tutorToUpdate = _context.Tutors.Find(id);
            if (tutorToUpdate == null)
            {
                return NotFound();
            }
            tutorToUpdate.FirstName = tut.FirstName;
            tutorToUpdate.LastName = tut.LastName;
            tutorToUpdate.Location = tut.Location;
            tutorToUpdate.Subject = tut.Subject;

            _context.SaveChanges();

            return Ok(tut);
        }

        [HttpDelete("~/api/tutors/{id}")]
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
