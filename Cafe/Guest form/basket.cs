using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Guest_form
{
    public class basket
    {
        public long id{ get; private set; }
        public string nameOfDishes { get; private set; }
        public float cost { get; private set; }
        public string type { get; private set; }
        public string timeOfCooking { get; private set; }
        public basket(long id, string nameOfDishes, float cost,string type, string timeOfCooking)
        {
            this.cost = cost;
            this.type = type;
            this.id = id;
            this.nameOfDishes = nameOfDishes;
            this.timeOfCooking = timeOfCooking;
        }
    }
}
