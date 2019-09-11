using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutorTime.Models;

namespace TutorTime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutoringRequestController : ControllerBase
    {
        private readonly TutorDbContext _Context;


    }
}