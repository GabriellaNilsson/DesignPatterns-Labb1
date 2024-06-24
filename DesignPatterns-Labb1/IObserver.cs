using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Labb1
{
    // Observer-Pattern
    public interface IObserver
    {
        void Update(string message);
    }
}
