using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Models
{
    public class Bill : BaseHome
    {
        public string BillNo { get; set; }
        public string CustomerNameSurname { get; set; }
        public int FoodPiece { get; set; }
        public int DrinkPiece { get; set; }
        public decimal FoodPrice { get; set; }
        public decimal DrinkPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public int PaymentId { get; set; }
        public int? DrinkId { get; set; }
        public int? FoodId { get; set; }
        public int TableId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Payment Payment { get; set; }
        public virtual Table Table { get; set; }
        public virtual Drink Drink { get; set; }
        public virtual Food Food { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
