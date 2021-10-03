using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvent
{
    internal class Program
    {
        public static void Stam()
        {

        }
        public static void Print1()
        {
            Console.WriteLine("Shalom");
        }
        public static void Print2()
        {
            Console.WriteLine("Another function called With same delegate");
        }
        public static void SayHolla(string name)
        {
            Console.WriteLine("Welcome " + name);
        }
        public static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Stam);
            myDelegate();
            Console.WriteLine(myDelegate.Method);
            Console.WriteLine(myDelegate.Target);//just for none static methods
            MyFirstDelegate print1 = new MyFirstDelegate(Print1);
            MyFirstDelegate print2 = new MyFirstDelegate(Print2);
            Greet greet = new Greet(SayHolla);
            Form1 form1 = new Form1();
            Student student1 = new Student() { Id = 1, Name = "usama"};
            Student student2 = new Student() { Id = 2, Name = "sami"};
            MyDelegate myDelegate1 = new MyDelegate(student1.Go);
            MyDelegate myDelegate2 = new MyDelegate(student1.Go);
            StudentTable.Log = new FilleLogger().Log;
        }
    }
}
