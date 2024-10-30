using KaffeFactoryPattern.Beverages;
using KaffeFactoryPattern.Factories;
using KaffeFactoryPattern.Interface;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace KaffeFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vores medlemmer
            ClubMember percy = new ClubMember("percy", "CAPPUCCINO");
            ClubMember donald = new ClubMember("Donald Yapper", "Latte");
            ClubMember jane = new ClubMember("Just Jane", "tea");


            BeverageFactory beverageFactory = new BeverageFactory();


            // Lav en Cappuccino
            IBeverage cup1 = beverageFactory.MakeBeverage(percy.BeveragePreference);
            cup1.Brew(); // Output: Brygger en Cappuccino med skummet mælk.

            // Lav en Latte
            IBeverage cup2 = beverageFactory.MakeBeverage(donald.BeveragePreference);
            cup2.Brew(); // Output: Brygger en Latte med dampet mælk.

            // Lav en kop Te
            IBeverage cup3 = beverageFactory.MakeBeverage(jane.BeveragePreference);
            cup3.Brew(); // Output: Brygger en kop te.


            void NotFactoryMethodExample(ClubMember member)
            {

                if (member.BeveragePreference.ToLower() == "cappuccino")
                {
                    Cappuccino cupOfCappuccino = new Cappuccino();
                }


                if (member.BeveragePreference.ToLower() == "latte")
                {
                    Latte cupOfLatte = new Latte();
                }


                if (member.BeveragePreference.ToLower() == "tea")
                {
                    Tea cupOfTea = new Tea();
                }

                else
                {
                    throw new ArgumentException("Ugyldig kaffetype");
                }


            }

        }
    }
}
