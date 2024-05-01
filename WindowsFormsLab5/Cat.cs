using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLab5
{
    class Cat:HouseAnimal
    {
        string[] CatBreeds = { "cat1", "cat2", "cat3" };
        private string _breed;
        public string Breed
        {
            get => _breed;
            set => _breed = value;
        }

        public Cat(string name, int age, int health, string breed, string color, string owner, string home) 
            : base(name, age, health, color, owner,home)
        {
            if (CatBreeds.Contains(breed))
            { Breed = breed; }
            else { throw new ArgumentOutOfRangeException(); }
        }
    }
}
