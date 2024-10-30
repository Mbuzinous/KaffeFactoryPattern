using KaffeFactoryPattern.Factories;
using KaffeFactoryPattern.Interface;
using System.Linq.Expressions;

namespace KaffeFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageFactory beverageFactory = new BeverageFactory();


            // Lav en Cappuccino
            IBeverage cappuccino = beverageFactory.MakeBeverage("cappuccino");
            cappucci    no.Brew(); // Output: Brygger en Cappuccino med skummet mælk.

            // Lav en Latte
            IBeverage latte = beverageFactory.MakeBeverage("latte");
            latte.Brew(); // Output: Brygger en Latte med dampet mælk.

            // Lav en kop Te
            IBeverage tea = beverageFactory.MakeBeverage("tea");
            tea.Brew(); // Output: Brygger en kop te.
        }
    }
}
