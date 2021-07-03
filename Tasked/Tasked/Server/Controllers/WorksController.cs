using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tasked.Server.Context;
using Tasked.Shared.Data;

namespace Tasked.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorksController : ControllerBase
    {

        private readonly AppDbContext _context;
        public WorksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Work>>> GetProdutos()
        {
            return await _context.Works.ToListAsync();
        }
    }
}
