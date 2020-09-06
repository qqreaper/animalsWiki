using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsWiki
{
    class Specifications
    {
        public decimal Height;
        public string Name;
        public int LifeTime;
        public decimal Weight;

        public Specifications CreateSpecifications(decimal height, string name, int lifeTime, decimal weight)
        {
            Specifications specifications = new Specifications();
            specifications.Height = height;
            specifications.Name = name;
            specifications.LifeTime = lifeTime;
            specifications.Weight = weight;

            return specifications;
        }
    }
}
