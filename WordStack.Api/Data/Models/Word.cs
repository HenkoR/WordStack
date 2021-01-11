using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordStack.Api.Data.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string StringValue { get; set; }
        
        public int WordTypeId { get; set; }
        public WordType WordType { get; set; } 
    }
}
