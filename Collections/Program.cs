//#region Array
using System.Text;
using System.Collections;

Console.OutputEncoding = Encoding.UTF8;  //for ciryllic

////double[] temperatures = new double[10];
//double[] temperatures = [10, 5, 3];
////double[] temperatures = new double[] { 10, 5, 3 };

//Random random = new(); // Экземпля класса рандом;
//Console.WriteLine(temperatures.Length);

//for (int i = 0; i < temperatures.Length; i++)
//{
//    temperatures[i] = random.NextDouble() * 40;
//    Console.WriteLine(i + " " + temperatures[i]);
//}

//double average = temperatures.Average();
//double max = temperatures.Max();
//double min = temperatures.Min();

//Console.WriteLine("average: " + average);
//Console.WriteLine("Температура датчиков " + string.Join(", ", temperatures.Select(t => t.ToString("F3"))));

////2
//string[] people = { "Tom", "Alice", "Bob", "Sam", "Tim", "Tomas", "Bill" };

////var selectedPeople = people.Where(p => p.Length == 3); // "Tom", "Bob", "Sam", "Tim"

////LINQ operator
//var selectedPeople = from p in people
//                     where p.Length == 3
//                     select p;

//foreach (string person in selectedPeople)
//    Console.WriteLine(person);

////3 

//double[,] temperature = new double[2, 2]; // [,] - two-dimensional array

//for (int i = 0; i < temperature.GetLength(0); i++)
//{

//    for (int j = 0; j < temperature.GetLength(1); j++)
//    {
//        temperature[i, j] = random.NextDouble() * 40;

//    }
//}

//Console.WriteLine("Температура датчиков");
//for (int i = 0; i < temperature.GetLength(0); i++)
//{

//    for (int j = 0; j < temperature.GetLength(1); j++)
//    {
//        Console.WriteLine($"{temperature[i, j]:F2}");

//    }
//    Console.WriteLine();
//}



//#region List   - динамический список

//List<Orders> orders = new List<Orders>(5); // size
//List<Orders> orders = new List<Orders>() { new Orders(), new Orders() };
//List<Orders> orders = new();
//List<Orders> orders = [];

//orders.Add(new Orders());
//orders.Remove(new Orders());

//foreach (var order in orders.OrderBy(o => o.OrderDate))
//{
//    Console.WriteLine(order);
//}

// IEnumerable -  работает с любыми последовательностями в C#
//public interface IEnumerable  
//{
//    IEnumerator GetEnumerator();
//}

//4
//string[] people = { "Tom", "Sam", "Bob" };

//IEnumerator peopleEnumerator = people.GetEnumerator(); // получаем IEnumerator
//while (peopleEnumerator.MoveNext())   // пока не будет возвращено false
//{
//    string item = (string)peopleEnumerator.Current; // получаем элемент на текущей позиции
//    Console.WriteLine(item);
//}
//peopleEnumerator.Reset(); // сбрасываем указатель в начало массива

//5 Реализация IEnumerable и IEnumerator
//Week week = new Week();
//foreach (var day in week)
//{
//Console.WriteLine(day);
//}

//class Week : IEnumerable
//{
//    string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
//                         "Friday", "Saturday", "Sunday" };
//    public IEnumerator GetEnumerator() => days.GetEnumerator();
//}


//// Create a list of integers
//List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

//// Use IEnumerable to iterate through the list
//IEnumerable<int> enumerableNumbers = numbers;

//// Using foreach loop to iterate over IEnumerable
//foreach (var number in enumerableNumbers)
//{
//    Console.WriteLine(number);
//}


////IEnumerable<int> collection = [4, 2, 6];
//IEnumerable<int> collection = new int[] 
//{ 
//    4, 2, 6
//};


////final for enumerable

//IEnumerable<Order> orders = GetOrders(); //it doesn't save in the memory
////IEnumerable<Order> orders = GetOrders().ToList(); //if you have 2 or more foreach. it saves in the memory

//foreach (var order in orders)
//{
//    Console.WriteLine("something");
//}
//foreach (var order in orders)
//{
//    Console.WriteLine("something");
//}
//IEnumerable<Order> GetOrders()
//{
//    return new List<Order>
//    {
//        new Order { OrderId = 1, CustomerName = "John Doe", TotalAmount = 100.50m },
//        new Order { OrderId = 2, CustomerName = "Jane Smith", TotalAmount = 200.75m }
//    };

//    //yield return 1;   // пооследовательное возвращение 
//    //yield return 2;
//    //yield return 3;
//}

//public class Order
//{
//    public int OrderId { get; set; }
//    public string CustomerName { get; set; }
//    public decimal TotalAmount { get; set; }
//}



// #region Dictionary

var dictionary = new Dictionary<int, string?>
{
    { 1, "value1" },
    { 2, "value2" },
    { 3, "value3" }
};

//dictionary.Add(1, "value1");
//dictionary.Add(2, "value2");
//dictionary.Add(3, "value3");

var value = dictionary.TryGetValue(2, out string? str);
Console.WriteLine(value);


//#region Queue

Queue<string> queue = new();

// 1.Добавление все элеиенты в очереди
queue.Enqueue("first element");
queue.Enqueue("second element");
queue.Enqueue("third element");



////#region LinkedList

//LinkedList<Order> oreders = new();
