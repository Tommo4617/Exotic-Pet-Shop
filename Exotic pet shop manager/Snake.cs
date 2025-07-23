using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exotic_pet_shop_manager
{
    internal class Snake: Pet
    {


        public Snake(string name, string species, string breed, int age, int price) : base(name, species, breed, age, price)
        {

        }

        public override string GetSpeciesInfo()
        {
            return $"This snake is  of the {breed} breed, aged {age} years, and is priced at ${price}. It can live up to around 20 years and commonlyfeeds on large rodents such as rats and mice.";
        }
    }
}
