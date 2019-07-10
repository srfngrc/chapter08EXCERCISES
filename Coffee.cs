using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter08EXERCICES
{
    class Coffee : IHotDrink
    {
        public bool Instant { get; set; }
        public bool Milk { get; set; }
        public byte Sugar { get; set; }
        public string Description { get; set; }

        public byte AddSugar(byte quantity)
        {
            //Code that adds some sugar
            //throw new NotImplementedException();
            return quantity;
        }
    }
}
