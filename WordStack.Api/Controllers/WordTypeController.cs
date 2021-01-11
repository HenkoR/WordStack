using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordStack.Api.Data;
using WordStack.Api.Data.Models;

namespace WordStack.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordTypeController : ControllerBase
    {
        readonly ILogger<WordTypeController> _logger;
        readonly WordStackDbContext _context;

        public WordTypeController(ILogger<WordTypeController> logger, WordStackDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<WordType>> Get()
        {
            return await _context.WordTypes.OrderBy(x => x.StringValue).ToListAsync();
        }
    }
}
