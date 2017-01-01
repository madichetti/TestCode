using System;

namespace TestCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Parenthesis match */
            var programtest = new ParenthesisMatch();
            var input = "ja(sd)()";
            Console.WriteLine(programtest.Execute(input) ? $"Parenthesis Matched in string `{input}`" : $"Parenthesis did not Match in string `{input}`");
            input = "ja(sd))(";
            Console.WriteLine(programtest.Execute(input) ? $"Parenthesis Matched in string `{input}`" : $"Parenthesis did not Match in string `{input}`");

            /* Reverse String */

            var reverseTest = new ReverseString();
            input = "This is a sentence waiting to be reversed.";
            Console.WriteLine($"`{input}` is reversed as `{reverseTest.Execute(input)}`");



            /* Finally wait for all code to execute */
            Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }


    }
}
