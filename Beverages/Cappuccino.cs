using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaffeFactoryPattern.Interface;

namespace KaffeFactoryPattern.Beverages
{
    public class Cappuccino : IBeverage
    {
        public void Brew()
        {
            Console.WriteLine("Hej og god morgen, jeg kan se at din preference er en Cappuccino, jeg starter med at brygge med det samme!");
        }
    }
}
