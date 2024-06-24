using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Labb1
{
    // Factory Method-Pattern
    public abstract class Question
    {
        public string Text { get; set; }
        public abstract void Ask();
    }
}
