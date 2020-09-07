using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AnimalsWiki
{
    class CatView
    {
        public Animal[] animals = new Animal[6] { new Animal().CreateAnimal(@"Images\BengalCat.jpg", File.ReadAllText(@"Descriptions\BengalCat.txt"),
                new Specifications().CreateSpecifications(20, "Бенгальская кошка", 14, 6)),

            new Animal().CreateAnimal(@"Images\BritishShorthair.jpg", File.ReadAllText(@"Descriptions\BritishShorthair.txt"),
                new Specifications().CreateSpecifications(20, "Британская короткошерстная", 15, 7)),

            new Animal().CreateAnimal(@"Images\Karakal.jpg", File.ReadAllText(@"Descriptions\Karakal.txt"),
                new Specifications().CreateSpecifications(35, "Каракал", 17, 18)),

            new Animal().CreateAnimal(@"Images\Mandalay.jpg", File.ReadAllText(@"Descriptions\Mandalay.txt"),
                new Specifications().CreateSpecifications(20, "Мандалай", 18, 5)),

            new Animal().CreateAnimal(@"Images\MaineCoon.jpg", File.ReadAllText(@"Descriptions\MaineCoon.txt"),
                new Specifications().CreateSpecifications(50, "Мейн кун", 13, 10)),

            new Animal().CreateAnimal(@"Images\Siamese.jpg", File.ReadAllText(@"Descriptions\Siamese.txt"),
                new Specifications().CreateSpecifications(20, "Сиамская кошка", 13, 6)),
        };
    }
}
