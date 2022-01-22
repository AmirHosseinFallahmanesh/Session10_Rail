using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface ISender
    {
        void Send(string text);
    }
    class MCIGsm : ISender
    {


        public void Send(string text)
        {
            Console.WriteLine("Send By MCI");
        }
    }

    interface IMark
    {
        void Send();
        int MyProperty { get; set; }
    }
}
