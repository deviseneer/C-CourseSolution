// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        //Expressions();
        //HomeWorkGetMax();
        //Loop();
        //NestedLoops();
        //DoWhile();
        //BreakContinue();
        //SwitchCase();
        //Debugging();
        //Fibonachi();
        //Homework4();
        //Factorial();
        //Login();
        //Arrays();
        //CollectionList();
        //CollectionDict();
        //StackQueue();
        //TwoDimensionalArrays();
        //JaggedArrays();
        AdjustableIndexArrays();

    }

    static void AdjustableIndexArrays() {

        Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
        myArray.SetValue(2019, 1);
        myArray.SetValue(2020, 2);
        myArray.SetValue(2021, 3);
        myArray.SetValue(2022, 4);

        Console.WriteLine($"Starting index: { myArray.GetLowerBound(0)}");
        Console.WriteLine($"Ending index: { myArray.GetUpperBound(0)}");

        for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
        {
            Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
        }
        Console.WriteLine();

        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
        }

    }
    static void JaggedArrays() //зубчатый массив или массив массивов 
    {
        int[][] jaggedArray = new int[4][];
        jaggedArray[0] = new int[1];
        jaggedArray[1] = new int[3];
        jaggedArray[2] = new int[2];
        jaggedArray[3] = new int[4];

        Console.WriteLine("Enter the numbers for a jagged array");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                string st = Console.ReadLine();
                jaggedArray[i][j] = int.Parse(st); 
            }
        }

        Console.WriteLine();
        Console.WriteLine("Printing the Elements");

        for(int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }





    }
    static void TwoDimensionalArrays()
    {
        // 1 2 3 4

        // 1 2 3 
        // 4 5 6 

        int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6} };
        int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6} };

        for (int i = 0; i < r2.GetLength(0); i++)
        {

            for (int j = 0; j < r2.GetLength(1); j++)
            {
                Console.Write($"{r2[i, j]} - ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
    static void StackQueue()
    {
        //Abstract Data Type
        // Implements LIFO - "Last-in First-Out"
        // Operations:
        //push - add item to the top
        //pop - remove the top item
        //peek - get the top item without removing
        // Can be backed up by an array or a linked list

        //FIFO - First in First out
        //Enqueue - add an item to the end of the queue
        //Dequeue - remove an item from the queue
        //Peek - get an item at the front of the queue without removing

        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        Console.WriteLine($"Should print out 1: {queue.Peek()}");

        queue.Dequeue();

        Console.WriteLine($"Should print out 2: {queue.Peek()}");

        Console.WriteLine("Iterate over the queue");
        foreach (var cur in queue)
        {
            Console.WriteLine(cur);
        }

        Console.ReadLine();






        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);

        Console.WriteLine($"Should print out 4: {stack.Peek()}");

        stack.Pop();

        Console.WriteLine($"Should print out 3: {stack.Peek()}");

        Console.WriteLine("Iterate over the stack");
        foreach (var cur in stack)
        {
            Console.WriteLine(cur);
        }

    }
    static void CollectionDict()
    {
        //Ассоциативный массив
        var people = new Dictionary<int, string>();
        people.Add(1,"John");
        people.Add(2,"Bob");
        people.Add(3,"Alice");

        people = new Dictionary<int, string>()
        {
            { 1, "John" },
            { 2, "Bob" },
            { 3, "Alice" }
        };

        string name = people[1];
        Console.WriteLine(name);

        Console.WriteLine("iterating over keys");
        //var keys = people.Keys;
        Dictionary<int, string>.KeyCollection keys = people.Keys;
        foreach(var item in keys)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("iterating over values");
        Dictionary<int, string>.ValueCollection values = people.Values;
        foreach (var item in values)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("iterating over key-value pairs");
        foreach (var pair in people)
        {
            Console.WriteLine($"Key: {pair.Key}. Value: {pair.Value}");
        }
        Console.WriteLine();

        Console.WriteLine($"Count={people.Count}");

        bool containsKey = people.ContainsKey(2);
        bool containsValue = people.ContainsValue("John");

        Console.WriteLine($"Contains key: {containsKey}. Contains value: {containsValue}");

        people.Remove(1);

        if(people.TryAdd(2, "Elias"))
        {
            Console.WriteLine("Added successfully Elias");
        }
        else
        {
            Console.WriteLine("Failed to add using key 2");
        }

        if (people.TryGetValue(2, out string val))
        {
            Console.WriteLine($"Key 2, Val = {val}");
        }
        else
        {
            Console.WriteLine("Failed to add key 2");
        }


    }
    static void CollectionList()
    {
        var intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        intList.Add(7);
        int[] intArray = { 1,2,5 };
        intList.AddRange(intArray);

        if (intList.Remove(1))  //first occurance
        {
            //do
        }
        else { }

        intList.RemoveAt(0);

        intList.Reverse();

        bool contains = intList.Contains(3);
        Console.WriteLine(contains);

        int min = intList.Min();
        int max = intList.Max();

        Console.WriteLine($"Min={min}. Max={max}");

        int indexOf = intList.IndexOf(2);
        int indexLastOf = intList.LastIndexOf(2);

        Console.WriteLine($"indexOf={indexOf}. indexLastOf={indexLastOf}");

        for (int i = 0; i < intList.Count; i++)
        {
            Console.WriteLine($"{intList[i]}");
        }
        Console.WriteLine();


    }
    static void Arrays()
    {
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int index = Array.BinarySearch(numbers, 7);
        Console.WriteLine(index);

        int[] copy = new int[10];
        Array.Copy(numbers, copy, numbers.Length);

        int[] anotherCopy = new int[10];
        copy.CopyTo(anotherCopy, 0);

        Array.Reverse(copy);
        foreach(var c in copy)
        {
            Console.WriteLine(c);
        }
        Console.WriteLine();

        Array.Sort(copy);
        foreach (var c in copy)
        {
            Console.WriteLine(c);
        }

        Array.Clear(copy, 0, copy.Length);
        


        int[] a1;
        a1 = new int[10];

        int[] a2 = new int[5];
        int[] a3 = new int[5] { 1, 2, 5, 10, -3};
        int[] a4 = { 1, 2, 5, 10, -3};

        Array myArray = new int[5];
        Array myArray2 = Array.CreateInstance(typeof(int), 5);
        myArray2.SetValue(12, 0);
        Console.WriteLine(myArray2.GetValue(0));

    }
    static void Login()
    {
        string login = "johnsilver";
        string pass = "qwerty";
        int tries = 1;

        Console.WriteLine("Enter Login and pass");

        while (tries <= 3)
        {
            tries++;
            string userLogin = Console.ReadLine();
            string userPass = Console.ReadLine();
            if (userLogin == login && userPass == pass)
            {
                Console.WriteLine("Enter the System");
                break;
            }
            if (tries == 4)
            {
                Console.WriteLine("The number of available tries have been exceeded");
            }
        }
    }
    static void Factorial()
    {
        Console.WriteLine("Enter a number to get a Factorial of it");
        int number = int.Parse(Console.ReadLine());
        BigInteger a = 1;

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
            a *= i;
        }
        Console.WriteLine(a);


    }
    static void Homework4()
    {
        Console.WriteLine("Enter 10 digits to get average");
        int[] numbers = new int[10];
        int inputCount = 0;
        
        while (inputCount < 10)
        {
           int number = int.Parse(Console.ReadLine());
            numbers[inputCount] = number;


           inputCount++;
            if (number == 0)
                break;
        }

        int sum = 0;
        int count = 0;

        foreach (int n in numbers)
        {
            Console.Write(n);
            if (n > 0)
            {
                sum += n;
                count++;
            }

        }

        double average = (double)sum / count;
        Console.WriteLine();
        Console.WriteLine(sum);
        Console.WriteLine(average);
        

    }
    static void Fibonachi()
    {
        Console.WriteLine("Enter the number of Fibonachi you want to generate");
        int numbers = int.Parse(Console.ReadLine());

        int[] array = new int[numbers];
        int a = 0;
        int b = 1;
        int f = 0;
        array[0] = a;
        array[1] = b;

        for (int i = 2; i < numbers; i++)
        {
            f = a + b;
            a = b;
            b = f;
            array[i] = f;

        }
        foreach (int c in array)
        {
        Console.Write(c);
        }
        Console.ReadLine();

    }
    static void Debugging()
    {
        // F9 F10 F11 F5
        Console.WriteLine("Enter the length of AB please");
        double a = GetDouble();
        Console.WriteLine("Enter the length of BC please");
        double b = GetDouble();
        Console.WriteLine("Enter the length of CA please");
        double c = GetDouble();

        double perimeter = (a + b + c) / 2;
        //double semiPerimeter = (a + b + c) * 0.5;
        double square = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
        Console.WriteLine($" Square of the triangle is {square} meter square 2");


        Console.ReadLine(); 
    }
    static double GetDouble()
    {
        return double.Parse(Console.ReadLine());
    }

    static void SwitchCase()
    {
        Console.WriteLine("Enter month number");
        int month = int.Parse(Console.ReadLine());

        string season = string.Empty;
        switch (month)
        {
            case 1:
            case 2:
            case 12:
                season = "Winter";
                break;
            case 3:
            case 4:
            case 5:
                season = "Spring";
                break;
            case 6:
            case 7:
            case 8:
                season = "Summer";
                break;
            case 9:
            case 10:
            case 11:
                season = "Autumn";
                break;
             default:
                throw new ArgumentException("Unexpected number of month");
        }
        Console.WriteLine(season);

        //int weddingYears = int.Parse(Console.ReadLine());

        //string name = string.Empty;

        //switch (weddingYears)
        //{
        //    case 5:
        //        name = "Wooden wedding";
        //        break;
        //    case 10:
        //        name = "Tin wedding";
        //        break;
        //    case 15:
        //        name = "Crystal wedding";
        //        break;
        //    case 20:
        //        name = "Porcelain wedding";
        //        break;
        //    case 25:
        //        name = "Silver wedding";
        //        break;
        //    case 30:
        //        name = "Pearls wedding";
        //        break;
        //    default:
        //        name = "do not know the name";
        //        break;
        //}
        //Console.WriteLine(name);
    }
    static void BreakContinue()
    {
        int[] numbers2 = { 0, 3, 2, 6, 1, 3, 2, 1, 5, 9, 1, 4, 2, 5 };
        char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };


        foreach (int n in numbers2)
        {
            if (n % 2 != 0)
                continue;
            Console.WriteLine(n);
        }

        for (int i = 0; i < numbers2.Length; i++)
        {
            Console.WriteLine($"Number = { numbers2[i]}");
            //My variant
            //for (int j = 0; j < numbers2[i]; j++)
            //{
            //   Console.Write($" {letters[j]} ");
            //}
            for (int j = 0; j < letters.Length; j++)
            {
                if (numbers2[i] == j)
                    break;
                Console.Write($" {letters[j]} ");
            }
            Console.WriteLine();
        } 

        //int[] numbers = { 1, -2, 4, 6, -7, 3, 2, -1, 5, 9, -8, 4, 2, -3 };
        //int counter = 0;
        //for (int i = 0; i < numbers.Length - 1; i++)
        //{
        //    if (counter == 3)
        //        break;
        //    for (int j = i + 1; j < numbers.Length; j++)
        //    {
        //        //Console.WriteLine(++m);
        //        int atI = numbers[i];
        //        int atJ = numbers[j];

        //        if (atI + atJ == 0)
        //        {
        //            Console.WriteLine($"Pair ({atI}; {atJ}). Indexes ({i}; {j})");
        //            counter++;
        //        }
        //        if (counter == 3)
        //            break;
        //    }
        //}
        //Console.WriteLine();

    }
    static void DoWhile()
    {
        //int age = 0;
        //while (age < 18)
        //{
        //    Console.WriteLine("First while loop");
        //    Console.WriteLine("What's your age");
        //    age = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("good");

        //do
        //{
        //    Console.WriteLine("Do\\While");
        //    Console.WriteLine("What's your age");
        //    age = int.Parse(Console.ReadLine());
        //}
        //while (age < 18);

        int[] numbers = { 1, 2, 3, 4, 5};
        int i = 0;
        while (i < numbers.Length)
        {
            Console.WriteLine(numbers[i] + " ");
            i++;
        }

    }
    static void NestedLoops()
    {
        int[] numbers = {1, -2, 4, 6, -7, 3, 2, -1, 5, 9, -8, 4, 2, -3 };
        //int m = 0;
        //for (int i = 0; i < numbers.Length - 1; i++)
        //{
        //    for (int j = i + 1; j < numbers.Length; j++)
        //    {
        //        //Console.WriteLine(++m);
        //        int atI = numbers[i];
        //        int atJ = numbers[j];

        //        if (atI + atJ == 0)
        //        {
        //            Console.WriteLine($"Pair ({atI}; {atJ}). Indexes ({i}; {j})");
        //        }
        //    }
        //}
        Console.WriteLine();

        for (int i = 0; i < numbers.Length - 2; i++)
        {
            for (int j = i + 1; j < numbers.Length - 1; j++)
            {
                for (int k = j + 1; k < numbers.Length - 1; k++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];
                    int atK = numbers[k];

                    if (atI + atJ + atK == 0)
                    {
                        Console.WriteLine($"Pair ({atI}; {atJ} ; {atK}). Indexes ({i}; {j}; {k})");
                    }
                }
                 
                
            }
        }
    }
    static void Loop()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //for (int i = 0; i < numbers.Length;  i++)
        //{
        //    Console.WriteLine(numbers[i] + " ");
        //}
        //Console.WriteLine();
        //for (int i = numbers.Length - 1; i >= 0; i--)
        //{
        //    Console.WriteLine(numbers[i] + " ");
        //}

        //Console.WriteLine();
        //for (int j = 0; j < numbers.Length; j++)
        //{
        //    if (numbers[j] % 2 == 0)
        //    {
        //    Console.WriteLine(numbers[j] + " ");
        //    }
        //}

        foreach (int val in numbers)
        {
            Console.WriteLine(val + "");
        }




    }

    static void HomeWorkGetMax()
    {
        Console.WriteLine("Enter an integer #1");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an integer #2");
        int b = int.Parse(Console.ReadLine());

        // first
        //int max = a;
        //if (b > a)
        //    max = b;

        //second
        //int max;
        //if (a > b)
        //    max = a;
        //else
        //    max = b;

        //third
        int max = a > b ? a : b;
            
        Console.WriteLine($" Max number is {max}");
    }
    static void Expressions()
    {
        Console.WriteLine("Enter name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your weight");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter your height in cm");
        double height = double.Parse(Console.ReadLine());

        double bodyMassIndex = weight / (height / 100 * height / 100);

        bool isTooLow = bodyMassIndex <= 18.5;
        bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;
        bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
        bool isTooFat = bodyMassIndex > 30;

        bool isFat = isAboveNormal || isTooFat;

        if (isFat)
        {
            Console.WriteLine("You'd better lose some weight");
        }
        else
        {
            Console.WriteLine("Oh, you're in a good shape.");
        }

        //if(isFat == false)
        if (!isFat)
        {
            Console.WriteLine("You're definitely not fat!");
        }
        else if (isTooLow)
        {
            Console.WriteLine("Not enough weight");
        }
        else if (isNormal)
        {
            Console.WriteLine("Be careful");
        }
        else
        {
            Console.WriteLine("You need to lose some weight");
        }

        if (isFat || isTooFat)
        {
            Console.WriteLine("Anyway it's time to go on a diet");
        }

        // ternary operation
        string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";
        // the same in if-else construct
        //if (age > 18)
        //{
        //    description = "You can drink alcohol";
        //}
        //else
        //{
        //    description = "You should get a bit older";
        //}

        Console.WriteLine(description);
    }
}

