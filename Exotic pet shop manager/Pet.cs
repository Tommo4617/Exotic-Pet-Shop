using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exotic_pet_shop_manager
{
    internal abstract class Pet
    {
        protected string name;
        protected string species;
        protected string breed;
        protected int age;
        protected int price;

        public Pet(string name, string species, string breed, int age, int price)
        {
            this.name = name;
            this.species = species;
            this.breed = breed;
            this.age = age;
            this.price = price;
        }

        public string GetPetInfo()
        {
            return $"Name: {name}, Species: {species}, Breed: {breed}, Age: {age} years, Price: ${price}";
        }

        public abstract string GetSpeciesInfo();
        

    }
}
