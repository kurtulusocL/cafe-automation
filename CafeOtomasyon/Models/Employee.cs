using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Models
{
    public class Employee:BaseHome
    {
        public string NameSurname { get; set; }
        public string Photo { get; set; }

        public ICollection<Bill> Bills { get; set; }
    }
}
