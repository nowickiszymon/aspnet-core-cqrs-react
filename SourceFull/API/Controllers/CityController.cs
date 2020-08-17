using System.Collections.Generic;
using System.Threading.Tasks;
using SourceFullStoreDb;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly DataContext _Context;
        public CityController(DataContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>>  Get()
        {
            var values = await _Context.Cities.ToListAsync();
            return Ok(values);
        }
    }
}