using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeFactoryPattern
{
    public class ClubMember
    {
        public string Name { get; set; }
        public string BeveragePreference{ get; set; }

        public ClubMember(string name, string beveragePreference) 
        {
            Name = name;
            BeveragePreference = beveragePreference;
        }
    }
}
