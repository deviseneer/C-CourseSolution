using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    //public abstract class IBaseCollection
    //{
    //    public abstract void Add(object obj);
    //    public abstract void Remove(object obj);

    //    public virtual void Clear()
    //    {
    //        Console.WriteLine("Default Implementation");
    //    }
    //}

    //public class BaseList : IBaseCollection
    //{
    //    private object[] items;
    //    private int count = 0;
    //    public BaseList(int initialCapacity)
    //    {
    //        items = new object[initialCapacity];
    //    }
    //    public override void Add(object obj)
    //    {
    //        items[count] = obj;
    //        count++;
    //    }

    //    public override void Remove(object obj)
    //    {
    //        items[count] = null;
    //        count--;
    //    }
    //}




    public interface IBaseCollection
    {
        void Add(object obj); // object is not used anymore
        void Remove(object obj);


        //void Clear(); // breaking change will happen you add it after all
    }

    public static class BaseCollectionExtension
    {
        public static void Addrange(this IBaseCollection collection, IEnumerable<object> objects)
        {
            foreach (var item in objects)
            {
                collection.Add(item);
            }
        }
    }

    public class BaseList : IBaseCollection
    {
        private object[] items;
        private int count = 0;
        public BaseList(int initialCapacity)
        {
            items = new object[initialCapacity];
        }
        public void Add(object obj)
        {
            items[count] = obj;
            count++;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
