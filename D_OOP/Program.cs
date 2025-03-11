// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character(Race.Elf);






            //IShape rect = Rect() { Height = 2, Width = 5 };   //no idead why there is an error
            //IShape square = Square { SideLength = 10 };


            //Console.WriteLine($"Rect area = {rect.CalcSquare()}");
            //Console.WriteLine($"Square area = {square.CalcSquare()}");

            //Console.ReadLine();



            //Rect rect = new Rect { Height = 2, Width = 5 };
            //int rectArea = AreaCalculator.CalcSquare(rect);
            //Console.WriteLine($"Rect area = {rectArea}");

            //Rect square = new Square { Height = 2, Width = 10 };
            //AreaCalculator.CalcSquare(square);




            //List<object> list = new List<object>() { 1, 2, 3, 4 };
            //IBaseCollection collection = new BaseList(4);
            //collection.Addrange(list);
            //collection.Add(1);

            //Shape shape = new Shape(); it's impossible to create abstract class

            //Shape[] shapes = new Shape[2];
            //shapes[0] = new Triangle(10, 20, 30);
            //shapes[1] = new Rectangle(5, 10);

            //foreach (Shape shape in shapes)
            //{
            //    shape.Draw();
            //    Console.WriteLine(shape.Perimeter());
            //}


            //ModelXTerminal terminal = new ModelXTerminal("123");
            //terminal.Connect();

            //Console.ReadLine();









            //Character c = new Character("Elf"); // constructor and creating copies
            //Console.WriteLine(c.Race);









            //int x = 1;
            //object obj = x;  // boxing process

            //int y = (int)obj; // unboxing process

            double pi = 3.14;
            object obj1 = pi;

            int number = (int)(double)obj1; 
            Console.WriteLine(number);





            //PointValStruct? pv = null;
            //if (pv.HasValue)
            //{
            //PointValStruct pv2 = pv.Value;
            //Console.WriteLine(pv.Value.X);
            //Console.WriteLine(pv2.X);
            //}

            //PointValStruct pv3 = pv.GetValueOrDefault();

            //PointRefClass c = null;
            //Console.WriteLine(c.X); // NullReferenceException






            //int a = 1;
            //int b = 2;

            //Swap(a, b); //(ref a, ref b)

            //Console.WriteLine($"Last a = {a}, b = {b}");

            //Console.ReadLine();

            //var list = new List<int>();
            //AddNumbers(list);
            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}






            //EvilStruct es1 = new EvilStruct();
            //es1.PointRefClass = new PointRefClass() { X = 1, Y = 2 }; // object initializer // can be Properties and Variables(Свойства и поля)
            ////es1.PointRefClass.X = 1;
            ////es1.PointRefClass.Y = 2;
            //EvilStruct es2 = es1;

            //Console.WriteLine($"es1.PointRefClass.X {es1.PointRefClass.X}, es1.PointRefClass.Y {es1.PointRefClass.Y}");
            //Console.WriteLine($"es1.PointRefClass.X {es2.PointRefClass.X}, es1.PointRefClass.Y {es2.PointRefClass.Y}");

            //es2.PointRefClass.X = 42;
            //es2.PointRefClass.Y = 45;

            //Console.WriteLine($"es1.PointRefClass.X {es1.PointRefClass.X}, es1.PointRefClass.Y {es1.PointRefClass.Y}");
            //Console.WriteLine($"es1.PointRefClass.X {es2.PointRefClass.X}, es1.PointRefClass.Y {es2.PointRefClass.Y}");

            //Console.ReadLine();


            //// for structs, separate memory is allocated
            //PointValStruct a; // the same as PointVal a = new PointVal();
            //a.X = 3;           
            //a.Y = 5;

            //PointValStruct b = a;
            //b.X = 7;
            //b.Y = 10;

            //a.LogValues();
            //b.LogValues();

            //Console.WriteLine("After structs");

            //PointRefClass c = new PointRefClass();  //classes are referential
            //c.X = 3;
            //c.Y = 5;

            //PointRefClass d = c;
            //d.X = 7;
            //d.Y = 10;

            //c.LogValues();
            //d.LogValues();






            //Calculator.CalcTriangleSquareOP(10, 20, 30); //optional params



            //Character c1 = new Character();
            //Character c2 = new Character();

            //Console.WriteLine($"c1.Speed = {c1.PrintSpeed()}. c2.Speed = {c2.PrintSpeed()}");

            //c1.IcreaseSpeed();

            //Console.WriteLine($"c1.Speed = {c1.PrintSpeed()}. c2.Speed = {c2.PrintSpeed()}");





            //// if class is static you cannot create a copy of class
            //double  result = Calculator.Average3(1,2,3); // static calling without copy
            //Console.WriteLine(result);



            //Calculator calc = new Calculator();
            //if (calc.TryDivide(10, 2, out double result)) 
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Failed to divide");
            //}

            //Console.ReadLine();





            //Console.WriteLine("Enter a number, please");

            //string line = Console.ReadLine();
            //int number;
            //bool wasParsed = int.TryParse(line, out number);

            //if (wasParsed)
            //{
            //Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Failed to parse");
            //}




            //calc.CalcTriangleSquare(a: 10,b: 20, c: 30,v: true); //named arguments




            //double avg = calc.Average(new int[] { 1, 2, 3, 4 });
            //double avg2 = calc.Average2( 1, 2, 3, 4 );
            //Console.WriteLine(avg);




            ////Character c = new Character();
            ////c.Hit(120);
            ////Console.WriteLine(c.Health);
            //Calculator calc = new Calculator();
            //double square1 = calc.CalcTriangleSquare(10, 20);
            //double square2 = calc.CalcTriangleSquare(25, 20, 30);

            //double square3 = calc.CalcTriangleSquare(25, 20, 50);

            //Console.WriteLine($"Square1 = {square1}. Square = {square2}. Square3 = { square3}");
        }

        private static IShape Rect()
        {
            throw new NotImplementedException();
        }

        static void Do(object obj)  //obj is used very rarely / instead is used generics
        {
            bool isPointRef = obj is PointRefClass;
            if (isPointRef)
            {
                PointRefClass pr = (PointRefClass)obj;
                Console.WriteLine(pr.X);
            }
            else
            {
                //do smth
            }

            PointRefClass pr1 = obj as PointRefClass;
            if (pr1 != null)
            {
                Console.WriteLine(pr1.X);
            }
            else
            {

            }
        }

        static void Swap(int a, int b) // (ref int a, ref int b)
        {
            Console.WriteLine($"Original a = {a}, b = {b}");

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swapped a = {a}, b = {b}");

        }
        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
    }
}
