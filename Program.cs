using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int fizz = 3;
            int buzz = 5;
            int limit = 10000;

            while(count <= limit){
                string output = "";

                if(count % fizz == 0){
                    output += "fizz";
                }
                if(count % buzz == 0){
                    output += "buzz";
                }
                if(count % buzz != 0 && count % fizz != 0){
                    output += count;
                }

                Console.WriteLine(output);
                count++;
            }
        }
    }
}
