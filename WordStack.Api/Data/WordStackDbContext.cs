using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordStack.Api.Data
{
    public class WordStackDbContext : DbContext
    {
        public WordStackDbContext(DbContextOptions<WordStackDbContext> options) : base(options)
        {

        }

        public DbSet<Models.WordType> WordTypes { get; set; }
        public DbSet<Models.Word> Words { get; set; }
        public DbSet<Models.Sentence> Sentences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
