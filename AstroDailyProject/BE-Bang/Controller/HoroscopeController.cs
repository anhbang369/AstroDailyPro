using AstroDailyProject.BE_Bang.Model;
using AstroDailyProject.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstroDailyProject.BE_Bang.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoroscopeController : ControllerBase
    {
        private readonly AstroDailyDBContext _context;

        public HoroscopeController(AstroDailyDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateHoroscope(HoroscopeModel horoscopeModel)
        {
            try
            {
                var horoscope = new Horoscope
                {
                    AspectId = horoscopeModel.AspectId,
                    LifeAttributeId = horoscopeModel.LifeAttributeId,
                    Date = horoscopeModel.Date,
                    Description = horoscopeModel.Description
                };
                _context.Add(horoscope);
                _context.SaveChanges(); ;
                return Ok(horoscope);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
