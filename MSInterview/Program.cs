using System;

namespace MSInterview
{
    public class Program
    {
        static void Main(String[] args)
        {
            //Console.WriteLine("Hello world - C#!");
        }

        // input: 123, output:321
        // static int reverse(int x)
        // {
        //     123 % 10 = 3
        //     123 / 10 = 12
        //     12 % 10 = 2
        // }

        // input: ABC
        static string reverse(string x)
        {
            //if(!String.isemptyornull(x)) { return x;}

            var result = string.Empty; // Result = '';

            for (var i = x?.Length - 1; i > -1; i--) // i = 2
            {
                result += x[(int)i];            // result = 'C'    i = 2
                                                // result = 'CB'   i = 1
                                                // result = 'CBA'  i = 0
            }

            return result;   // returns 'CBA'
        }

        // num1 = "55", num2 = "525", output "550"9999999 1

        static string Sum(string num1, string num2)
        {
            var result = string.Empty;

            var large = (num1.Length > num2.Length) ? num1 : num2;
            var small = (num1.Length > num2.Length) ? num2 : num1;
            var carry = 0;
            var temp = 0;

            for (var i = large.Length; i > -1; i--)
            {
                if (i < small.Length)
                {
                    temp = int.Parse(large[i].ToString()) + int.Parse(small[i].ToString()) + carry;   // temp  = 10       // temp 2 + 2 + 1 = 5
                    carry = (temp > 9) ? 1 : 0;                                 // carry = 1        // carry = 0
                }
                else // add any carry figures
                {
                    temp = int.Parse(large[i].ToString()) + carry;              // temp  = 10       // temp 2 + 2 + 1 = 5
                    carry = (temp > 9) ? 1 : 0;                                 // carry = 1        // carry = 0
                }

                result = result + (temp % 10).ToString();                       // result = '0'     // result = '50'
            }


            var difference = large.Length - small.Length;                       // diff = 3 - 2 (1)
                                                                                // start, take count
            result = result + large.Substring(0, difference);                   // result = '5' + '50' = '550'

            if (carry == 1)
            {
                result = result + "1";
            }

            return result;
        }

    }

}