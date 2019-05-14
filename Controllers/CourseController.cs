using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GolfScoreStoringWebApplication.Models;

namespace GolfScoreStoringWebApplication.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        golfapplicationContext _context;

        public CourseController(golfapplicationContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public void WeatherForecasts()
        {
            var courseInfo = new PlaceLocation()
            {
                Id = Guid.NewGuid(),
                Name = "Trent Lock",
                Address1 = "Lock Lane",
                PostCode = "NG10 3QB"
            };

            _context.PlaceLocation.Add(courseInfo);
            _context.SaveChanges();
        }
    }
}
