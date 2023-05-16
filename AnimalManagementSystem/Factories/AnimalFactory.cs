using AnimalManagementSystem.Models;

namespace AnimalManagementSystem.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public Animal CreateAnimal(string type)
        {
            switch (type.ToLower())
            {
                case "dog":
                    return new Dog();

                case "cat":
                    return new Cat();

                default:
                    throw new ArgumentException("Invalid animal type.");
            }
        }
    }
}