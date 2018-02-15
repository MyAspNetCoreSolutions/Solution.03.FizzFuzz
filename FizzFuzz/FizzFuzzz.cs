using System;

namespace FizzFuzz
{
    public class FizzFuzzz
    {
        public string GetText(int input)
        {
            string result = "";
            for (int i = 1; i <= input; i++)
            {
                if (i%3==0 && i%5==0)
                {
                    result += "FizzFuzz,";
                }
                else if (i % 5 == 0)
                {
                    result += "Fuzz,";
                }
                else if (i % 3 == 0)
                {
                    result += "Fizz,";
                }
                else
                {
                    result += $"{i},";
                }
            }

            return result.Substring(0,result.Length-1);
        }

    }
}
