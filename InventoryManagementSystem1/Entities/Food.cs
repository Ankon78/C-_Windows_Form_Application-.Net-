using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefsFoodManagement.Entities
{
    class Food
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string FoodCategory { get; set; }
        public string MfgDate { get; set; }
        public string ExpDate { get; set; }
        public int Quantity { get; set; }
        public int PerUnitPrice { get; set; }
        public string Ingredients { get; set; }
    }
}
