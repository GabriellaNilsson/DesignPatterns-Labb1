using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace DesignPatterns_Labb1
{
    // Singleton-Pattern and Observer-Pattern
    public class QuizManager
    {
        private static QuizManager _instance;
        private static readonly object _lock = new object();
        private List<IObserver> _observers = new List<IObserver>();

        private QuizManager() { }

        public static QuizManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new QuizManager();
                    }
                    return _instance;
                }
            }
        }

        public List<Question> Questions { get; private set; } = new List<Question>();
        public int Score { get; private set; }

        public void LoadQuestions(List<Question> questions)
        {
            Questions = questions;
            NotifyObservers("Welcome to my quiz");
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        public void CheckAnswer(Question question, int answer)
        {
            if (question is MultipleChoiceQuestion mcq)
            {
                if (mcq.CorrectOption == answer)
                {
                    Score++;
                    NotifyObservers("Correct answer!");
                }
                else
                {
                    NotifyObservers("Wrong answer.");
                }
            }
            else if (question is TrueFalseQuestion tfq)
            {
                bool correctAnswer = answer == 1;
                if (tfq.CorrectAnswer == correctAnswer)
                {
                    Score++;
                    NotifyObservers("Correct answer!");
                }
                else
                {
                    NotifyObservers("Incorrect answer.");
                }
            }
        }
    }
}
