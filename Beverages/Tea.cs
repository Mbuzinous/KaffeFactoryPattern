using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaffeFactoryPattern.Interface;

namespace KaffeFactoryPattern.Beverages
{
    public class Tea : IBeverage
    {
        public void Brew()
        {
            Console.WriteLine("Brygger en kop Te.");
        }
    }
}
