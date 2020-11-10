using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Models
{
    public class Drink : BaseHome
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Bill> Bills { get; set; }
        public ICollection<Table> Tables { get; set; }
    }
}
