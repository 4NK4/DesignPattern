using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiderPattern
{
   abstract class PersonBuilder
    {
        protected string Graphics;
        protected string Pen;
        public PersonBuilder(string graphics, string pen)
        {
            Graphics = graphics;
            Pen = pen;
        }

        public abstract void builderHead();
        public abstract void builderbody();
        public abstract void builderHands();
        public abstract void builderFoot();

    }
}
