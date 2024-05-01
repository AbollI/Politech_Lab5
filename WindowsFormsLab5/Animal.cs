using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLab5
{
    class Animal
    {
        public enum AnHealth:int
        {
            perfect=0,
            good=1,
            fine=2,
            bad=3,
            dead=4

        }

        private int _age;
        private string _name;
        private int _health;
        private string _color;


        public int Age
        {
            get => _age;
            set => _age = value > 0 ? value : throw new ArgumentOutOfRangeException();
        }

        public string Name
        {
            get => _name;
            set => _name=value;
        }

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public Animal(string name,int age, int health, string color)
        {
            Age = age;
            Name = name;
            if (Enum.IsDefined(typeof(AnHealth), health)) { Health = health; }
            else { throw new ArgumentOutOfRangeException(); }
            Color = color;
        }
    }
}
