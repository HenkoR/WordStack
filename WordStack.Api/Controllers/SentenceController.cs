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
    public class SentenceController : ControllerBase
    {
        readonly ILogger<SentenceController> _logger;
        readonly WordStackDbContext _context;

        public SentenceController(ILogger<SentenceController> logger, WordStackDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Sentence>> Get()
        {
            return await _context.Sentences.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post(Sentence sentence)
        {
            try
            {
                _context.Sentences.Add(new Sentence { StringValue = sentence.StringValue });
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return StatusCode(500, $"There was an error saving your sentence, please try again.{Environment.NewLine}If the problem persists contact your administrator");
            }
        }
    }
}
