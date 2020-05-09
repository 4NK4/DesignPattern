using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiderPattern
{
    class PersonFat : PersonBuilder
    {
        public PersonFat(string graphics, string pen) : base(graphics, pen) { }

        public override void builderbody()
        {
            Console.WriteLine($"{Graphics}{Pen}画了胖子的身体.");
        }

        public override void builderFoot()
        {
            Console.WriteLine($"{Graphics}{Pen}画了胖子的足.");
        }

        public override void builderHands()
        {
            Console.WriteLine($"{Graphics}{Pen}画了胖子的手.");
        }

        public override void builderHead()
        {
            Console.WriteLine($"{Graphics}{Pen}画了胖子的头.");
        }
    }
}
