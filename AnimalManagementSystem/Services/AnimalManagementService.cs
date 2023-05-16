using AnimalManagementSystem.Models;
using AnimalManagementSystem.Factories;

namespace AnimalManagementSystem.Services
{
    public class AnimalManagementService
    {
        private readonly IAnimalFactory _animalFactory;

        public AnimalManagementService(IAnimalFactory animalFactory)
        {
            _animalFactory = animalFactory;
        }

        public void CreateAndMakeSound(string animalType)
        {
            Animal animal = _animalFactory.CreateAnimal(animalType);
            animal.MakeSound();
        }
    }
}