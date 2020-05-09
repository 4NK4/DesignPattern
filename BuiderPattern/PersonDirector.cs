using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiderPattern
{
    class PersonDirector
    {
        private PersonBuilder pb;
        public PersonDirector(PersonBuilder pb)
        {
            this.pb = pb;
        }

        public void CreatePerson()
        {
            pb.builderHead();
            pb.builderbody();
            pb.builderHands();
            pb.builderFoot();
        }



    }
}
