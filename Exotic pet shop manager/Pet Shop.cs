using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exotic_pet_shop_manager
{
    internal class Pet_Shop
    {
        public List<Pet> pets;


        public int mainMenu()
        {
            bool validInput = false;
            int choice = 0;
            while (!validInput)
            {
                Console.WriteLine("Welcome to the Exotic pet shop! \n Would you like to: \n 1. View all pets \n 2. Add a new pet \n 3. Exit");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    validInput = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{e} \n");
                    
                }
            }
            return choice;

        }

        public int SelectNewPetSpecies()
        {
            bool validInput = false;
            int choice = 0;
            while (!validInput)
            {
                Console.WriteLine("What species is the pet you are wanting to add? \n 1. Snake \n 2. Taranchula \n 3. Lizard \n 4. Gecko \n 5. Mantis");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if(choice < 1 || choice > 5)
                    {
                        throw new Exception("Please select a valid option between 1 and 5.");
                    }

                    validInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e} \n");

                }
                
            }
            return choice;

        }

        public void addNewPet(Pet pet)
        {
            if (pets == null)
            {
                pets = new List<Pet>();
            }
            pets.Add(pet);
            Console.WriteLine("New pet added successfully!");
        }


    }
}
