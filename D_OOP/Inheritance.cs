using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    //Наследие ООП
    public class BankTerminal
    {
        protected string id;

        public BankTerminal()
        {
            this.id = id;
        }

        public virtual void Connect()
        {
            Console.WriteLine("General Connecting Protocol...");
        }
    }

    public class ModelXTerminal : BankTerminal  //inheriting
    {
        public ModelXTerminal(string id) : base() //creating constructor
        {
            //base.id = id; // we can erase with inheriting this lane
        }
        public override void Connect()
        {
            
            base.Connect();
            Console.WriteLine("Additional actions for Model X");
        }
    }
    

    public class ModelYTerminal : BankTerminal  //inheriting
    {
        public ModelYTerminal(string id) : base() //creating constructor
        {
            //base.id = id; // we can erase with inheriting this lane
        }
        public override void Connect()
        {
            Console.WriteLine("Actions for Model Y");
        }
    }
}
