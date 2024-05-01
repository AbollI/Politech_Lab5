using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLab5
{
    public class HouseAnimal
    {
        private Animal _Animal;
        
        
        private string _owner;
        private string _home;
        

        public string Owner
        {
            get => _owner;
            set => _owner = value;
        }

        public string Home
        {
            get => _home;
            set => _home = value;
        }

        public HouseAnimal(string name, int age, int health, string color, string owner,string home)
        {
            _Animal = new Animal(name, age, health,color);
            Owner = owner;
            Home = home;
        }

    }
}
