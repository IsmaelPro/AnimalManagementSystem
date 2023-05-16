using AnimalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagementSystem.Factories
{
    public interface IAnimalFactory
    {
        Animal CreateAnimal(string type);
    }
}