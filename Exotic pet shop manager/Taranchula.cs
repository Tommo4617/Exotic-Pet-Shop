using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exotic_pet_shop_manager
{
    internal class Taranchula: Pet
    {
        public Taranchula(string name, string species, string breed, int age, int price)
            : base(name, species, breed, age, price)
        {
        }

        public override string GetSpeciesInfo()
        {
            return "Taranchulas are fascinating arachnids known for their large size and unique appearance. They are often kept as exotic pets due to their low maintenance needs and interesting behaviors.";
        }
    }
}
