using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Models
{
    public class Table : BaseHome
    {
        public DateTime CustomerArriving { get; set; }
        public DateTime? CustomerLeaving { get; set; }
        public bool IsRezervation { get; set; }
        public bool IsPaid { get; set; }
        public bool IsEmpty { get; set; }

        public int? DrinkId { get; set; }
        public int? FoodId { get; set; }
        public int TableNumberId { get; set; }

        public virtual Drink Drink { get; set; }
        public virtual Food Food { get; set; }
        public virtual TableNumber TableNumber { get; set; }

        public ICollection<Bill> Bills { get; set; }
    }
}
