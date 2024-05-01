using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLab5
{
    class Group
    {
        private HouseAnimal[] _members;

        public Group()
        {
            _members = new HouseAnimal[0];
        }

        public void AddMember(HouseAnimal newmember)
        {
            Array.Resize(ref _members, _members.Length + 1);
            _members[_members.Length - 1] = newmember;
        }
    }
}
