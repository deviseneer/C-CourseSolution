// See https://aka.ms/new-console-template for more information
using D_OOP;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text;


class Program
      {
        static void Main(string[] args)
        {
        Character c = new Character();
        c.Hit(20);
        Console.WriteLine(c.Health);
        //Variables();
        //Literals();
        //VariablesScope();
        //Overflow();
        //IncrementDecrementDemo();
        //MathOperations();
        //comparisonOperators();
        //StaticAndInstanceMembers();
        //subString();
        //emptyString();
        //changeString();
        //stringBuilder(); /* faster than concat */
        //formatString();
        //ComparisonString();
        //WorkingWithConsole();
        //TypeConversion();
        //Comments();
        //ClassMath();
        //Arrays();
        //MethodDateTime();
        //HomeWork();
        //HomeWork2();
        HomeWork3();
    }
        static void HomeWork3()
    {
        Console.WriteLine("Enter name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your weight");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter your height in cm");
        double height = double.Parse(Console.ReadLine());

        double index = weight / (height / 100 * height / 100);
        string profile = $" Your Profile: {Environment.NewLine}"
            + $" Your body mass Index {index}{Environment.NewLine}"
            + $" Your age {age}";

        Console.WriteLine(profile);


    }
        static void HomeWork2()
    {
        Console.WriteLine("Enter the length of AB please");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of BC please");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of CA please");
        double c = double.Parse(Console.ReadLine());

        double perimeter = (a+b+c) / 2;
        //double semiPerimeter = (a + b + c) * 0.5;
        double square = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
        Console.WriteLine($" Square of the triangle is {square} meter square 2");

      }
        static void HomeWork()
    {
        //1
        Console.WriteLine("What's your name ?");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}");

        //2
        Console.WriteLine("Enter an integer please");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Write any second number please");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"x = {x} y = {y}");
        int z = x;
        x = y;
        y = z;
        Console.WriteLine($"x = {x} y = {y}");

        //3
        Console.WriteLine("Write any number please");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine($"You wrote {a} and it contains of {a.ToString().Length} digits");

    }
        static void MethodDateTime()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToString());
        Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}");

        DateTime dt = new DateTime(2016, 1, 28);
        Console.WriteLine(dt);
        DateTime newDt = dt.AddDays(1);
        Console.WriteLine(newDt);

        TimeSpan ts = now - dt;
        //ts = now.Subtract(dt);
        Console.WriteLine(ts.Days);



    }
        static void Arrays()
    {
        //1 int = 4 bytes
        int[] a1;
        a1 = new int[10];

        int[] a2 = new int[5];
        int[] a3 = new int[5] {1,3,-3,5,10};
        int[] a4 = { 1, 2, -3, 18, 8 };

        Console.WriteLine(a4[0]);

        int number = a4[0];
        Console.WriteLine(number);

        a4[4] = 6;
        Console.WriteLine(a4[4]);

        Console.WriteLine(a4.Length);
        Console.WriteLine(a4[a4.Length - 1]);

        string s1 = "abcdefgh";
        char first = s1[0];
        char last = s1[s1.Length - 1];

        Console.WriteLine($"First: {first}. Last: {last}");

        // impossible for strings
        //s1[0] = 'z';


    }
        static void ClassMath()
    {
        Console.WriteLine(Math.Pow(2, 3));
        Console.WriteLine(Math.Sqrt(9));
        Console.WriteLine(Math.Sqrt(8));

        Console.WriteLine(Math.Round(1.7));
        Console.WriteLine(Math.Round(1.4));
        Console.WriteLine(Math.Round(1.5));
        Console.WriteLine();

        Console.WriteLine(Math.Round(3.5));

        Console.WriteLine(Math.Round(2.5));
        Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
        Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven)); //default






    }
        static void Comments()
    {
        // a single line comment

        /*
         * Multiline comment
         * We can write here many words
         * 
         */

        // describe how it happens and why ?

        int a = 1;

        // increment a by 1 - bad comment, this code is self-evident
        
        //we need to tweak the index to match the expected outcome
        a++; 


    }
        static void TypeConversion()
       {
        byte b = 3;   // 0000 0011  = 8 bit
        int i = b;    // 0000 0000 0000 0000 0000 0000 0000 0011 = 4 bytes
        long l = i;   // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011 = 8 bytes

        float f = i;
        Console.WriteLine(f);  // 3.0

        b = (byte)i; // явное приведение (cast)
        //Console.WriteLine(b);

        i = (int)f;
        //Console.WriteLine(i);

        f = 3.1f;
        i = (int)f;
        Console.WriteLine(i);

        string str = "1";
        //i = (int)str;  не сойдет
        i= int.Parse(str);
        Console.WriteLine($"Parsed i = {i}");

        int x = 5;
        int result = x / 2;
        Console.WriteLine(result);

        double result2 = (double)x / 2;
        Console.WriteLine(result2);


    }
        static void WorkingWithConsole()
    {
        //Console.WriteLine("Hi, please tell me your name");

        //string name = Console.ReadLine();
        //string sentence = $"Your name is {name}";
        //Console.WriteLine(sentence);

        Console.WriteLine("Hi, please tell me your age.");
        string input = Console.ReadLine();
        int age = int.Parse(input);

        string sentence = $"Your age is {age}";
        Console.WriteLine(sentence);

        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write("New Style ");
        Console.Write("New Style\n");


    }
        static void ComparisonString()
    {
        //string str1 = "abcde";
        //string str2 = "abcde";

        //bool areEqual = str1 == str2;
        //Console.WriteLine(areEqual);

        //areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
        //Console.WriteLine(areEqual);

        string str1 = "Strasse";
        string str2 = "Straße";

        bool areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
        Console.WriteLine(areEqual);
        areEqual = string.Equals(str1, str2, StringComparison.InvariantCulture);  /* not recommended */
        Console.WriteLine(areEqual);
        areEqual = string.Equals(str1, str2, StringComparison.CurrentCulture);
        Console.WriteLine(areEqual);

    }
        static void formatString()
    {
        string name = "K";
        int age = 30;
        string str1 = string.Format("My name is {0} and I'm {1}", name, age);
        string str2 = $"My name is {name} and I'm {age}"; /* интерпонирование строк */
        //string str2 = "My name is " + name + " and I'm " + age;

        string str3 = "My name is \nK";
        string str4 = "I'm \t30";

        str3 = $"My name is {Environment.NewLine}K";

        //string str5 = "I am K and I am a "good" coder";
        string str5 = "I am K and I am a \"good\" coder";
        //string str6 = "C:\\tmp\\test_file.txt";
        string str6 = @"C:\tmp\test_file.txt";   /* verbatim */

        //int answer = 42;
        //string result = string.Format("{0:d}", answer);
        //string result2 = string.Format("{0:d4}", answer);

        double answer = 42.23;
        string result = string.Format("{0:f}", answer);
        string result2 = string.Format("{0:f4}", answer);

        Console.OutputEncoding = Encoding.UTF8;

        double money = 12.8;
        result = string.Format("{0:C}", money);
        result2 = string.Format("{0:C2}", money);

        Console.WriteLine(money.ToString("C2"));
        //result = $"{money:C2}";
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        Console.WriteLine(result);
        Console.WriteLine(result2);

    }
        static void stringBuilder()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("My ");
        sb.Append("name ");
        sb.Append("is ");
        sb.Append("K ");
        sb.AppendLine("!");
        sb.AppendLine("Hello!");

        string str = sb.ToString();
        Console.WriteLine(str);

    }
        static void changeString()
    {
        string nameConcat = string.Concat("My ", "name ", "is ", "K");
        Console.WriteLine(nameConcat);
        nameConcat = string.Join(" ", "My", "name", "is", "K");
        Console.WriteLine(nameConcat);

        nameConcat = "My " + "name " + "is " + "K";


        //string newName = 
        nameConcat = nameConcat.Insert(0, "By the way, ");

        Console.WriteLine(nameConcat);

        nameConcat = nameConcat.Remove(0, 1);
        Console.WriteLine(nameConcat);

        string replaced = nameConcat.Replace('n', 'z');
        Console.WriteLine(replaced);

        string data = "12;28;34;14;64";
        string[] splitData = data.Split(';');
        string first = splitData[0];
        Console.WriteLine(first);

        char[] chars = nameConcat.ToCharArray();
        Console.WriteLine(chars[0]);
        Console.WriteLine(nameConcat[0]);

        string lower = nameConcat.ToLower();
        Console.WriteLine(lower);

        string upper = nameConcat.ToUpper();
        Console.WriteLine(upper);

        string k = " My name is K ";
        Console.WriteLine(k.Trim());








    }
        static void emptyString()
    {
        string empty = "";
        string whiteSpaced = " ";
        string notEmpty = " b";
        string nullString = null;

        Console.WriteLine("isNullOrEmpty");
        bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
        Console.WriteLine(isNullOrEmpty);

        isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
        Console.WriteLine(isNullOrEmpty);

        isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
        Console.WriteLine(isNullOrEmpty);

        isNullOrEmpty = string.IsNullOrEmpty(empty);
        Console.WriteLine(isNullOrEmpty);

        Console.WriteLine();
        Console.WriteLine("IsNullOrWhiteSpace");

        bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
        Console.WriteLine(isNullOrWhiteSpace);

        isNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
        Console.WriteLine(isNullOrWhiteSpace);

        isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
        Console.WriteLine(isNullOrWhiteSpace);

        isNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
        Console.WriteLine(isNullOrWhiteSpace);

        


    }
        static void subString()
    {
        string name = "asdasdasd";
        bool ContainsA = name.Contains('a');
        bool ContainsE = name.Contains('E');

        Console.WriteLine(ContainsA);
        Console.WriteLine(ContainsE);

        bool endsWithAsd = name.EndsWith("asd");
        Console.WriteLine(endsWithAsd);

        bool startWithAsd = name.StartsWith("asd");
        Console.WriteLine(startWithAsd);

        int indexOfA = name.IndexOf('a', 1);
        Console.WriteLine(indexOfA);

        int lastIndexOfA = name.LastIndexOf('s');
        Console.WriteLine(lastIndexOfA);

        Console.WriteLine(name.Length);

        string substrFrom5 = name.Substring(5);
        string substrFromTo = name.Substring(0, 3);

        Console.WriteLine(substrFrom5);
        Console.WriteLine(substrFromTo);
    }
        static void StaticAndInstanceMembers()
    {
        string name = "asdasdas";
        bool containsA = name.Contains('a');
        bool containsE = name.Contains('E');
        Console.WriteLine(containsA);
        Console.WriteLine(containsE);

        string abc = string.Concat("a", "b", 'c');
        Console.WriteLine(abc);
        Console.WriteLine(int.MinValue);

        int x = 1;
        string xStr = x.ToString();
        Console.WriteLine(xStr);
        Console.WriteLine(x);
    }
        static void comparisonOperators()
    {
        int x = 1;
        int y = 2;

        bool areEqual = x == y;
        Console.WriteLine(areEqual);

        bool result = x > y;
        Console.WriteLine(result);

        result = x >= y;
        Console.WriteLine(result);

        result = x < y;
        Console.WriteLine(result);

        result = x <= y;
        Console.WriteLine(result);

        result = x != y;
        Console.WriteLine(result);

    }
        static void MathOperations()
    {
        int x = 1;
        int y = 2;

        int z = x + y;
        int k = x - y;
        int a = z + k - y;

        Console.WriteLine(z);
        Console.WriteLine(k);
        Console.WriteLine(a);

        int b = z * 2;
        int c = k / 2;

        Console.WriteLine(b);
        Console.WriteLine(c);

        a = 4 % 2;
        b = 5 % 2;

        Console.WriteLine(a);
        Console.WriteLine(b);

        a = 3;
        a = a * a;
        //a = a * a * a;
        Console.WriteLine(a);

        a = 2 + 2 * 2;
        Console.WriteLine(a);
        a *= 2;
        //a = a * 2;
        Console.WriteLine(a);
        a /= 2;
        //a = a / 2;
        Console.WriteLine(a);
    }
        static void IncrementDecrementDemo()
    {
        int x = 1;
        x = x + 1;

        Console.WriteLine(x);

        //postfix increment
        x++;
        Console.WriteLine(x);
        //infix increment
        ++x;
        Console.WriteLine(x);

        x = x - 1;
        x--;
        --x;
        Console.WriteLine(x);

        Console.WriteLine("Learn about increments");
        Console.WriteLine($"Last x state is {x}"); /* форматирование строк */

        int j = x++;
        Console.WriteLine(j);
        Console.WriteLine(x);

        j = ++x;
        Console.WriteLine(j);
        Console.WriteLine(x);

        x += 2;
        // x = x + 2
        Console.WriteLine(x);

        j -= 2;
        // j = j - 2
        Console.WriteLine(j);

        //int y = 1;
        //y = y - 1;
        //Console.WriteLine(y);
        ////decrement
        //y--;
        //Console.WriteLine(y);
        //--y;
        //Console.WriteLine(y);




    }
        //Переполнение
        static void Overflow()
        {
            //Блок
            checked  
             {
                uint x = uint.MaxValue;
        
                Console.WriteLine(x);

                x = x + 1;

                Console.WriteLine(x);

                x = x - 1;

                Console.WriteLine(x);
             }

    }
        static void VariablesScope()
    {
        var a = 1;
        {
            var b = 2;
            {
                var c = 3;

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            //Console.WriteLine(c);
        }
        Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);
    }
        static void Literals()
    {

        int x = 0b11;   /* числовой литерал в бинарном виде */
        int y = 0b1001;
        int k = 0b10001001;
        int m = 0b1000_1001;
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(k);
        Console.WriteLine(m);

        x = 0x1F;
        y = 0xFF0d;
        k = 0x1FAB30EF;
        m = 0x1FAB_30EF;

        Console.WriteLine();

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(k);
        Console.WriteLine(m);

        Console.WriteLine();

        Console.WriteLine(4.5e2); /* 4.5 x 10'2 = 450 */
        Console.WriteLine(3.1E-1); /* 3.1 x 10'-1 = 0,31 */

        Console.WriteLine();

        Console.WriteLine('\x78'); /* символьный литерал с пом кода */
        Console.WriteLine('\x5A');

        Console.WriteLine('\u0420'); /* символ из юникодной таблицы */
        Console.WriteLine('\u0421');
    }
        static void Variables()
        {
            //Console.WriteLine("Hello, World!");
            //Console.Read();
            int x = -1;
            //Int32 x1 = -1;
            int y;
            y = 2;

            //uint z = -1;

            float f = 1.1f;

            double d = 2.3;

            int x2 = 0;
            int x3 = new int();

            var a = 1;
            var b = 1.2;

            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //var dict = new Dictionary<int, string>();

            //var v;

            decimal money = 3.0m;

            char character = 'A';
            string name = "John";

            bool canDrive = true;
            bool canDraw = false;

            object obj1 = 1;
            object obj2 = "obj2";

            Console.WriteLine(a);
            Console.WriteLine(name);




        }
      }




