using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinationController : ControllerBase
    {
        private readonly HospitalmanagementContext _context;
        public VaccinationController(HospitalmanagementContext context)
        {
            _context = context;
        }
        // GET: api/<VaccinationController>
        [HttpGet]
        public IEnumerable<Vaccination> GetAllvaccines()
        {
            return _context.Vaccinations.ToList();
        }

       
    }
}
