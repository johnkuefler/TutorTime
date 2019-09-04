using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutorTime.Models;

namespace TutorTime.Controllers.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutoringRequestController : ControllerBase
    {
        private readonly TutorDbContext _context;

        public TutoringRequestController(TutorDbContext context)
        {
            _context = context;
        }
        [HttpGet("~/api/tutoringrequest")]
        public IActionResult GetAllRequests()
        {
            return Ok(_context.TutoringRequests.ToList());


        }
        [HttpGet ("~/api/tutoringrequest/{TutorId}")]
        public IActionResult GetRequestsByTutor(int TutorId) {

            return Ok(_context.Tutors.Find(TutorId)?.TutoringRequests);
        }

        [HttpPost]
        public IActionResult CreateRequest([FromBody] TutoringRequest request) {

            if (!ModelState.IsValid) {

                return BadRequest(ModelState);
            }
            _context.Add(request);
            _context.SaveChanges();

            return Ok(request);
        }

        [HttpPut]
        public IActionResult IncrementSession(int requestid) {

           var request =  _context.TutoringRequests.Find(requestid);
            if (request == null) {
                return NotFound();

            }

            request.NumberOfPeople++;
            _context.SaveChanges();

            return Ok(request);

        }
        [HttpDelete]
        public IActionResult DeleteSession(int sessionID) {
            var request = _context.TutoringRequests.Find(sessionID);
            _context.Remove(request);
            _context.SaveChanges();
            return Ok();


        }

    }
}