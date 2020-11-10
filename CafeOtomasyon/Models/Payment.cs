using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Models
{
    public class Payment : BaseHome
    {
        public string Name { get; set; }

        public ICollection<Bill> Bills { get; set; }
    }
}
