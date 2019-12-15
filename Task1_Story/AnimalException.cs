using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Story
{
    class AnimalException:Exception
    {
        public AnimalException(string message) : base(message) { }
    }

    class HouseException : Exception
    {
        public HouseException(string message) : base(message) { }
    }
}
