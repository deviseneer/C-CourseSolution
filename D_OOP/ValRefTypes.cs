using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public struct EvilStruct
    {
        public int X;
        public int Y;

        //public PointRefClass PointRefClass;

        // for readonly example
        public readonly PointRefClass PointRefClass;

        public EvilStruct(int x, int y)
        {
            X = x;
            Y = y;
            PointRefClass = new PointRefClass();
        }

        public void Do()
        {
            //PointRefClass = new PointRefClass(); //impossible from methods
        }

    }

    public struct PointValStruct
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"X = {X}; Y = {Y}");
        }
    }
    public class PointRefClass
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"X = {X}; Y = {Y}");
        }
    }
}
