using System;
using System.Linq;

namespace TestCode
{
    public class ReverseString
    {
        public string Execute(string input)
        {
            return string.Join(" ", input.Split(' ').Reverse());
        }
    }
}
