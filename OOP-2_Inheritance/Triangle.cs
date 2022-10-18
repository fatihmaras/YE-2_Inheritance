using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2_Inheritance
{
    public class Triangle : Shape
    {

        public Triangle()
        {

        }
        public Triangle(int x, int y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Triangle drawing task...");
            base.Draw();    // base draw ifadesi opsiyoneldir, draw methodundaki eylem lazımsa kalabilir ,değilse bu ifadenin yazılmasına gerek yok.
        }
    }
}

