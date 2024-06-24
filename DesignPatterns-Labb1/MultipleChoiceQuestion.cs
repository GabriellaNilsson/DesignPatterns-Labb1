using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Labb1
{
    // Factory Method-Pattern
    public class MultipleChoiceQuestion : Question
    {
        public List<string> Options { get; set; }
        public int CorrectOption { get; set; }

        public override void Ask()
        {
            Console.WriteLine(Text);
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine($"{i}. {Options[i]}");
            }
        }
    }
}
