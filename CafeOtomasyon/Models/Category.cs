using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Models
{
    public class Category : BaseHome
    {
        public string Name { get; set; }

        public ICollection<Drink> Drinks { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
