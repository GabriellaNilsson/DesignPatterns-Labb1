namespace DesignPatterns_Labb1
{
        public class Program
        {
            // All patterns used in this application: Singleton, Observer and Factory Method
            public static void Main(string[] args)
            {
                var quizManager = QuizManager.Instance;
                var ui = new UserInterface();
                quizManager.Attach(ui);

                var questions = new List<Question>
                {
                    new MultipleChoiceQuestionFactory().CreateQuestion(
                        "What does the 'static' keyword do in C#?",
                        new Dictionary<string, object> { { "options", new List<string> { "Makes a variable global", "Allows access to a method without creating an instance of the class", "Prevents inheritance" } }, { "correctOption", 1 } }),

                    new MultipleChoiceQuestionFactory().CreateQuestion(
                        "Which keyword is used to declare a method in C#?",
                        new Dictionary<string, object> { { "options", new List<string> { "function", "method", "void" } }, { "correctOption", 0 } }),

                    new MultipleChoiceQuestionFactory().CreateQuestion(
                        "What is the purpose of 'using' directive in C#?",
                        new Dictionary<string, object> { { "options", new List<string> { "Declare a new variable", "Define a class", "Specify the namespace to be used" } }, { "correctOption", 2 } }),

                    new MultipleChoiceQuestionFactory().CreateQuestion(
                        "What does the 'this' keyword refer to in C#?",
                        new Dictionary<string, object> { { "options", new List<string> { "Refers to a static method", "Refers to the current instance of the class", "Refers to the base class" } }, { "correctOption", 1 } }),

                    new TrueFalseQuestionFactory().CreateQuestion(
                        "Interfaces in C# can contain implementation of methods.",
                        new Dictionary<string, object> { { "correctAnswer", false } }),

                    new TrueFalseQuestionFactory().CreateQuestion(
                        "The 'void' keyword in C# indicates that a method does not return a value.",
                        new Dictionary<string, object> { { "correctAnswer", true } }),

                    new TrueFalseQuestionFactory().CreateQuestion(
                        "C# does not support multiple inheritance for classes.",
                        new Dictionary<string, object> { { "correctAnswer", true } })
                };

                quizManager.LoadQuestions(questions);

                foreach (var question in quizManager.Questions)
                {
                    question.Ask();
                    int answer = int.Parse(Console.ReadLine());
                    quizManager.CheckAnswer(question, answer);
                }
                Console.WriteLine($"Your final score is: {quizManager.Score} / 7");
                }
        }
}
