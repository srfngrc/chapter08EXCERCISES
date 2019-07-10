using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter08EXERCICES
{
    interface IHotDrink
    {
        //Properties
        bool Instant { get; set; }
        bool Milk { get; set; }
        byte Sugar { get; set; }
        string Description { get; set; }
        //Methods
        byte AddSugar(byte quantity);
    }
}
