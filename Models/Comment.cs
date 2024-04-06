using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public class Comment
    {
        public int Id {get; set;}
        public int StockId {get; set;}
        public string Title{get; set;} = string.Empty;
        public DateTime CreatedOn{get; set;} = DateTime.Now;
        public Stock? Stocks {get; set;}
        
    }
}