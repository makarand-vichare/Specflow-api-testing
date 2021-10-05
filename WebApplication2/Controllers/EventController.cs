using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public EventController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(GetAllEvents());
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            SocialEvent socialEvent = GetAllEvents().FirstOrDefault(o=>o.Id == id);
            return Ok(socialEvent);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok("Deleted");
        }

        [HttpPost]
        public IActionResult Post(SocialEvent socialEvent)
        {
            return Ok("Created");
        }

        private IEnumerable<SocialEvent> GetAllEvents()
        {
            return Enumerable.Range(1, 5).Select(index => new SocialEvent
            {
                Id = index,
                EventName = $"SocialEvent {index}",
                EventDate = DateTime.Now.AddDays(index),
            })
            .ToArray();
        }
    }
}
