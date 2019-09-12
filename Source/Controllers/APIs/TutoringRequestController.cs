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
       
        [HttpGet("{TutorId}")]
        public IActionResult GetRequestsByTutor(int TutorId)
        {

            
            return Ok(_context.TutoringRequests.Where(x => x.TutorId == TutorId
                                             && x.DateTime >= DateTimeOffset.Now.Date).ToList());
        }

        [HttpPost]
        public IActionResult CreateRequest([FromBody] TutoringRequest request)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }

            _context.Add(request);
            _context.SaveChanges();

            return Ok(request);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateRequest(int id,[FromBody]TutoringRequest request)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }
            _context.TutoringRequests.Update(request);
            _context.SaveChanges();

            return Ok(request);
        }


        [HttpPut("Join")]
        public IActionResult IncrementSession(int requestid)
        {

            var request = _context.TutoringRequests.FirstOrDefault(x => x.Id == requestid);
            if (request == null)
            {
                return NotFound();

            }

            request.NumberOfPeople++;
            _context.SaveChanges();

            return Ok(request);
        }
        [HttpDelete]
        public IActionResult DeleteSession(int sessionID)
        {
            var request = _context.TutoringRequests.FirstOrDefault(x => x.Id == sessionID);
            _context.Remove(request);
            _context.SaveChanges();
            return Ok();


        }

    }
}