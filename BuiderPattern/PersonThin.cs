using System;

namespace BuiderPattern
{
    class PersonThin : PersonBuilder
    {
        public PersonThin(string graphics, string pen) : base(graphics, pen) { }

        public override void builderbody()
        {
            Console.WriteLine($"{Graphics}{Pen}画了瘦子的身体.");
        }

        public override void builderFoot()
        {
            Console.WriteLine($"{Graphics}{Pen}画了瘦子的足.");
        }

        public override void builderHands()
        {
            Console.WriteLine($"{Graphics}{Pen}画了瘦子的手.");
        }

        public override void builderHead()
        {
            Console.WriteLine($"{Graphics}{Pen}画了瘦子的头.");
        }
    }
}
