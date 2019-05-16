using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GolfScoreStoringWebApplication.Models;

namespace GolfScoreStoringWebApplication.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class LocationController : Controller
    {
        golfapplicationContext _context;

        public LocationController(golfapplicationContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public void NewLocation()
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
