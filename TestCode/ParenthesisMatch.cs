using System.Diagnostics;

namespace TestCode
{
    public class ParenthesisMatch
    {
        public bool Execute(string input)
        {
            var parmatch = 0;
            foreach (var inputchar in input)
            {
                if (inputchar.ToString() == "(")
                {
                    parmatch++;
                    continue;
                }
                if (inputchar.ToString() == ")")
                {
                    parmatch--;
                    if (parmatch < 0)
                    {
                        Debug.Write($"<string>{input}</string> did not match paranthesis.");
                        return false;
                    }
                }
            }
            if (parmatch != 0)
            {
                Debug.Write($"<string>{input}</string> did not match paranthesis.");
                return false;
            }

            return true;
        }
    }
}
