using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvent
{
    public class ConsoleLogger : Ilogger
    {
        public void Log(string message)
        {
            Console.WriteLine("{0} {1} {2}", DateTime.Now, Environment.UserName, message);
        }
    }
}
