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
    public class WordController : ControllerBase
    {
        readonly ILogger<WordController> _logger;
        readonly WordStackDbContext _context;

        public WordController(ILogger<WordController> logger, WordStackDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("{typeId}")]
        public async Task<IEnumerable<Word>> Get(int typeId)
        {
            return await _context.Words.Where(x => x.WordTypeId == typeId).ToListAsync();
        }
    }
}
