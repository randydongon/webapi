using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public class Stock
    {
        public int Id {get; set;}
        public string Symbol {get; set;} = string.Empty;
        public string CompanyName {get; set;} = string.Empty;
        public string Purchase {get; set;} = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv {get; set;}
        [Column(TypeName = "decimal(18,2)")]
        public decimal MarketCap {get; set;}
        public List<Comment> Comments {get; set;} = new List<Comment>();
    }
}