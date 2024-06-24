using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Labb1
{
    // Factory Method-Pattern
    public class TrueFalseQuestion : Question
    {
        public bool CorrectAnswer { get; set; }

        public override void Ask()
        {
            Console.WriteLine($"{Text} (Enter 1 for true, and 0 or 2 for false)");
        }
    }
}
