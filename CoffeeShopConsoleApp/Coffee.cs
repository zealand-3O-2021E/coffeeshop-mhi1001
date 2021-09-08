using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        private int _discount;

        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        /// 
        public Coffee(int discount)
        {
            if (discount > 5)
            {
                throw new Exception("Discount cant be more than 5 kr");
            }
            _discount = discount;
        }

        public int Discount
        {
            get { return _discount; }
            set
            {
                if (value > 5)
                {
                    throw new Exception("Discount cant be more than 5 kr");
                }

                _discount = value;

            }
        }

        public virtual int price()
        {
            return 20 - Discount;
        }

        public abstract string Strength();

    }
}
