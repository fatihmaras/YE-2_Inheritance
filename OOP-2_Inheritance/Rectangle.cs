using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_2_Inheritance
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {


        }
        public Rectangle(int x, int y) : base(x, y)
        {
            //X = x;
            //Y = y;
        }
        public override void Draw()
        {
            System.Console.WriteLine("Rectangle drawing taks...");
            // base.Draw();
        }
        public void Calculate()
        {
            System.Console.WriteLine("Calculated by Rectangle...");
        }

    }
}
