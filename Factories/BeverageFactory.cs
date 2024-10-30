using KaffeFactoryPattern.Beverages;
using KaffeFactoryPattern.Interface;
using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeFactoryPattern.Factories
{
    public class BeverageFactory
    {
        public IBeverage MakeBeverage(string type)
        {
            switch (type.ToLower())
            {
                case "cappuccino":
                    return new Cappuccino();
                case "latte":
                    return new Latte();
                case "tea":
                    return new Tea();
                default:
                    throw new ArgumentException("Ugyldig kaffetype");
            }
        }
    }
}
