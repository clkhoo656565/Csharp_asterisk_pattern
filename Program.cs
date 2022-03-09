using System;

namespace Asterisk_pattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input = 0;
            string result = "";
            Console.WriteLine("Please enter a number");
            input = Convert.ToInt32(Console.ReadLine());
            result = Draw(input);

            Console.WriteLine(result);
        }

        public static string Draw(int input)
        {
            string output = "";
            
            for (int i = 1; i <= input; i++)
            {
                
                for (int j = input; j >= 1; j--)
                {
                    if(j <= i)
                        output += "*";
                    else
                        output += "_";
                    

                }
                output += "\n";
            }

            return output;
        }
    }
}
