using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLab5
{
    class Dog:HouseAnimal
    {
        string[] DogBreeds = { "dog1", "dog2", "dog3" };
        private string _breed;
        public string Breed
        {
            get => _breed;
            set => _breed = value;
        }

        public Dog(string name, int age, int health, string breed, string color, string owner,string home)
            :base( name, age, health, color, owner,home)
        {
            if (DogBreeds.Contains(breed))
            { Breed = breed; }
            else { throw new ArgumentOutOfRangeException(); }
        }
    }
}
