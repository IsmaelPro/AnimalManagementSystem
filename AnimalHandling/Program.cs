using AnimalManagementSystem.Factories;
using AnimalManagementSystem.Models;
using AnimalManagementSystem.Services;

namespace AnimalManagementSystem.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IAnimalFactory animalFactory = new AnimalFactory();
            AnimalManagementService animalManagementService = new AnimalManagementService(animalFactory);

            animalManagementService.CreateAndMakeSound("dog");
            animalManagementService.CreateAndMakeSound("cat");
        }
    }
}