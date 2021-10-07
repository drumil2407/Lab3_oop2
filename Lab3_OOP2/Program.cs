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
            Vector p1 = new Vector();
            //p1.Set(1, 1);

            

            //System.Console.WriteLine(p);

            //Point point = p.Position;

            //point.SetCoords(100, 100);

            //System.Console.WriteLine(p);

            // Phonon p2 = new Phonon(p); // making a copy of point p and store in p2
            // Console.WriteLine(p2);

            //Phonon p3 = new Phonon(0);
            //p3.Drift(1);
            //Console.WriteLine(p3);
            Phonon p = new Phonon(1);
            p.SetDirection(0.4,-0.2);
            Cell c = new Cell(7,8);
            c.AddPhonon(new Phonon(1));
            c.AddIncPhonon(new Phonon(2));
            Console.WriteLine(c);
            BoundarySurface bs = new BoundarySurface(SurfaceLocation.left, new Cell(10,10));
            BoundarySurface bs1 = new BoundarySurface(SurfaceLocation.right, new Cell(10,10));
            BoundarySurface bs2 = new BoundarySurface(SurfaceLocation.top, new Cell(10, 10));
            BoundarySurface bs3 = new BoundarySurface(SurfaceLocation.bottom, new Cell(10, 10));
            Console.WriteLine(p);
            bs.HandlePhonon(p);
            bs1.HandlePhonon(p);
            bs2.HandlePhonon(p);
            bs3.HandlePhonon(p);

            Console.WriteLine(p);
           // Cell c = new Cell(10,10);
            for (int i = 0; i < 30; i++)
            {

                if (i >= 20)
                {
                    c.AddIncPhonon(new Phonon(1));
                }
                else
                {
                    c.AddPhonon(new Phonon(1));
                }
            
            }
            Console.WriteLine(c);
            c.MergeIncPhonons();
            Console.WriteLine(c);
        }
    }
}
