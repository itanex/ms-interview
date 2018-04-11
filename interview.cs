using System;

class HelloWorld
{
	static void Main(String[] args)
	{
		//Console.WriteLine("Hello world - C#!");
	}

    // input: 123, output:321
    static int reverse(int x) 
    {
        123%10=3
        123/10=12
        12%10=2
    }

    // input: ABC
    static string reverse(string x) 
    {
        //if(!String.isemptyornull(x)) { return x;}

        var result = String.Empty; // Result = '';

        for (var i = x?.length - 1; i >- 1; i--) // i = 2
        {
            result += x[i];                 // result = 'C'    i = 2
                                            // result = 'CB'   i = 1
                                            // result = 'CBA'  i = 0
        }

        return result;   // returns 'CBA'
    }

    // num1 = "55", num2 = "525", output "550"9999999 1

    static string Sum(string num1, string num2) 
    {
        var result = string.Empty;

        var large = (num1.length > num2.length) ? num1 : num2;
        var small = (num1.length > num2.length) ? num2 : num1;
        var carry = 0;
        var temp = 0;

        for(var i = large.length; i > -1; i--)
        {
            if(i < small.length)
            {
                temp = int.parse(large[i]) + int.parse(small[i]) + carry;   // temp  = 10       // temp 2 + 2 + 1 = 5
                carry = (temp > 9) ? 1 : 0;                                 // carry = 1        // carry = 0
            }
            else // add any carry figures
            {
                temp = int.parse(large[i]) + carry;                         // temp  = 10       // temp 2 + 2 + 1 = 5
                carry = (temp > 9) ? 1 : 0;                                 // carry = 1        // carry = 0
            }

            

            result =+ temp % 10;                                        // result = '0'     // result = '50'
        }


        var difference =  large.length - small.length; // diff = 3 - 2 (1)
// start, take count
        result =+ large.substring(0, difference);    // result = '5' + '50' = '550'
        
        if(carry == 1)
        {
            result =+ '1';
        }
        
        return result;
    }
    
}
