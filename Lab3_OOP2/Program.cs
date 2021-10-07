using Psim.Geometry2D;
using Psim.ModelComponents;
using Psim.Particles;
using System;

namespace Lab3_OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vector p1 = new Vector();
            //p1.Set(1, 1);

            //Phonon p = new Phonon(1);

            //System.Console.WriteLine(p);

            //Point point = p.Position;

            //point.SetCoords(100, 100);

            //System.Console.WriteLine(p);

            //Phonon p2 = new Phonon(p); // making a copy of point p and store in p2
            //Console.WriteLine(p2);

            //Phonon p3 = new Phonon(0);
            //p3.Drift(1);
            //Console.WriteLine(p3);

            Cell c = new Cell(7,8);
            c.AddPhonon(new Phonon(1));
            c.AddIncPhonon(new Phonon(2));
            Console.WriteLine(c);
        }
    }
}
