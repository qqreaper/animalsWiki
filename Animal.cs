using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsWiki
{
    class Animal
    {
        public string ImagePath;
        public string description;
        public Specifications specifications;

        public Animal CreateAnimal(string imagePath, string description, Specifications spec)
        {
            Animal animal = new Animal();
            animal.ImagePath = imagePath;
            animal.description = description;
            animal.specifications = spec;

            return animal;
        }
    }
}
