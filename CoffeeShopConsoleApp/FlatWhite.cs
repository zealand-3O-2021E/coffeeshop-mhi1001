using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleApp
{
    class FlatWhite : Coffee
    {
        public FlatWhite(int discount) 
            : base(discount)
        {
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
