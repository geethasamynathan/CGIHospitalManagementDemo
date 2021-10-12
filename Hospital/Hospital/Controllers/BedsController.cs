using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hospital.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BedsController : ControllerBase
    {
        private readonly HospitalmanagementContext _context;
        public BedsController(HospitalmanagementContext context)
        {
            _context = context;
        }
        // GET: api/<BedsController>
        [HttpGet]
        public IEnumerable<Bed> GetAllBeds()
        {
            return _context.Beds.ToList();
        }

    }
}
