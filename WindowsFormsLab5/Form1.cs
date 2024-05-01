using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HouseAnimal hA1 = new HouseAnimal("name",5,3,"green","jim","somewherethere");
            
            Dog dog1 = new Dog("dogname1",5,0,"dog2","brown","jim","there");
            Dog dog2 = new Dog("dogname2", 4, 1, "dog1", "black", "jim", "there");
            Cat cat1 = new Cat("catname",6,1,"cat1", "orange", "jim", "there");
            Bird bird1 = new Bird("birdname",1,0,"bird3", "green", "jim", "there");

            Group House = new Group();
            House.AddMember(dog1);
            House.AddMember(cat1);
            House.AddMember(bird1);
            House.AddMember(dog2);

            int i = 1;
        }
    }
}
