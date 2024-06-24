using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Labb1
{
    // Observer-Pattern
    public class UserInterface : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine(message);
        }
    }
}
