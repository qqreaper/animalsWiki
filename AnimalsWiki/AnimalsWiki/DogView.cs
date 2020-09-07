using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AnimalsWiki
{
    class DogView
    {
        public Animal[] animals = new Animal[6] { new Animal().CreateAnimal(@"Images\AlaskaMalamut.jpg", File.ReadAllText(@"Descriptions\AlaskaMalamut.txt"),
                new Specifications().CreateSpecifications(63, "Аляскинский маламут", 16, 40)),

            new Animal().CreateAnimal(@"Images\AmericanBulldog.jpg", File.ReadAllText(@"Descriptions\AmericanBulldog.txt"),
                new Specifications().CreateSpecifications(65, "Американский бульдог", 11, 45)),

            new Animal().CreateAnimal(@"Images\Bloodxaunt.jpg", File.ReadAllText(@"Descriptions\Bloodxaunt.txt"),
                new Specifications().CreateSpecifications(65, "Бладхаунд", 11, 45)),

            new Animal().CreateAnimal(@"Images\Beagle.jpg", File.ReadAllText(@"Descriptions\Beagle.txt"),
                new Specifications().CreateSpecifications(35, "Бигль", 13, 10)),

            new Animal().CreateAnimal(@"Images\SmoothFoxTerrier.jpg", File.ReadAllText(@"Descriptions\SmoothFoxTerrier.txt"),
                new Specifications().CreateSpecifications(35, "Гладкошерстный фокстерьер", 14, 8)),

            new Animal().CreateAnimal(@"Images\Bullterrier.jpg", File.ReadAllText(@"Descriptions\Bullterrier.txt"),
                new Specifications().CreateSpecifications(50, "Бультерьер", 12, 30)),
        };

        
    }
}
