using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Labb1
{
    // Factory Method-Pattern
    public class MultipleChoiceQuestionFactory : QuestionFactory
    {
        public override Question CreateQuestion(string questionText, Dictionary<string, object> parameters)
        {
            return new MultipleChoiceQuestion
            {
                Text = questionText,
                Options = (List<string>)parameters["options"],
                CorrectOption = (int)parameters["correctOption"]
            };
        }
    }
}
