using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvent
{
    public class Student
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public void Go()
        {
            Console.WriteLine("My name is: " + Name);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
