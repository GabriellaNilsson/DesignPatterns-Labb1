using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Labb1
{
    // Factory Method-Pattern
    public abstract class QuestionFactory
    {
        public abstract Question CreateQuestion(string questionText, Dictionary<string, object> parameters);
    }
}
