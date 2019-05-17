using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GolfScoreStoringWebApplication.Models;
using System.Linq;

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

        [HttpPost("[action]")]
        public void NewLocation([FromBody]PlaceLocation newLocation)
        {
            newLocation.Id = Guid.NewGuid();

            _context.Add(newLocation);
            _context.SaveChanges();
        }

        [HttpGet("[action]")]
        public IActionResult GetLocations()
        {
            var locations = _context.PlaceLocation.ToList();

            return Ok(locations);
        }
    }
}
