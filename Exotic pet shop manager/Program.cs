// See https://aka.ms/new-console-template for more information
using Exotic_pet_shop_manager;

Pet_Shop petShop = new Pet_Shop();
petShop.mainMenu();
petShop.SelectNewPetSpecies();
Snake snake = new Snake("Slithery", "Python", "Ball Python", 3, 150);
petShop.addNewPet(snake);
Console.WriteLine(snake.GetPetInfo()); 
