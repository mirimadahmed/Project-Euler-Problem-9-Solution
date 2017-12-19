using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Hello, world!");
            for(int a = 1; a < 998; a++)
                for (int b = a + 1; b < 998; b++)
                    for( int c = b + 1; c < 998; c++)
                        if (isPyTriple(a,b,c))
                            if(a + b + c == 1000)
                            {
                                Console.WriteLine(a);
                                Console.WriteLine(b);
                                Console.WriteLine(c);
                                Console.WriteLine(a*b*c);
                            }
            
            
            
            
        }
        
        static bool isPyTriple(int a, int b,int c){
            return (a * a) + (b * b) == (c * c);
        }
    }
}
