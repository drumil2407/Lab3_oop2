using Microsoft.VisualStudio.TestTools.UnitTesting;
using Psim.ModelComponents;
using Psim.Particles;
using System;

namespace SurfaceTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HandlePhonon()
        {
            Phonon p = new Phonon(1);
            p.SetDirection(0.2, -0.2);
            Cell c = new Cell(7, 8);
            c.AddPhonon(new Phonon(1));
            c.AddIncPhonon(new Phonon(2));
           // Console.WriteLine(c);
            BoundarySurface bs = new BoundarySurface(SurfaceLocation.left, new Cell(10, 10));
            BoundarySurface bs2 = new BoundarySurface(SurfaceLocation.top, new Cell(10, 10));
            bs.HandlePhonon(p);
            bs2.HandlePhonon(p);
           // Console.WriteLine(p);
        }
        [TestMethod]
        public void MergePhonon()
        {

            Cell c = new Cell(10, 10);
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
