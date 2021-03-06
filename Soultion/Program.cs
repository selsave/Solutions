using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiverseSpace

{
    class Program
    {
        static void Main(string[] args)
        {
            Soultion obj = new Soultion();
            Console.WriteLine("Example 1: A=6,B=1 & C=1");
            Console.WriteLine(obj.solution(6, 1, 1));
            Console.WriteLine("Example 2: A=1,B=3 & C=1");
            Console.WriteLine(obj.solution(1, 3, 1));
            Console.WriteLine("Example 3: A=0,B=1 & C=8");
            Console.WriteLine(obj.solution(0, 1, 8));
            Console.WriteLine("--------Correctness----------");
            Console.WriteLine("Super small: A=1,B=1,C=1");
            Console.WriteLine(obj.solution(1, 1, 1));
            Console.WriteLine("2 Zeros, A=0,B=0,C=3");
            Console.WriteLine(obj.solution(0, 0, 3));
            Console.WriteLine("2 Zeros, A=3,B=0,C=0");
            Console.WriteLine(obj.solution(3, 0, 0));
            Console.WriteLine("2 Zeros, A=0,B=6,C=0");
            Console.WriteLine(obj.solution(0, 6, 0));
            Console.WriteLine("All Equal: A=4,B=4,C=4");
            Console.WriteLine(obj.solution(4, 4, 4));
            Console.WriteLine("One  Big: A=10,B=2,C=2");
            Console.WriteLine(obj.solution(10, 2, 2));
            Console.WriteLine("One  Big: A=2,B=12,C=2");
            Console.WriteLine(obj.solution(2, 12, 2));
            Console.WriteLine("One  Big: A=2,B=2,C=10");
            Console.WriteLine(obj.solution(2, 2, 10));
            Console.WriteLine("Two Big: A=25,B=20,C=0");
            Console.WriteLine(obj.solution(25, 20, 0));
            Console.WriteLine("Two Big: A=25,B=20,C=2");
            Console.WriteLine(obj.solution(25, 20, 2));
            Console.WriteLine("Max: A=55,B=65,C=75");
            Console.WriteLine(obj.solution(55, 65, 75));
            //Console.WriteLine("All 0: A=0,B=0,C=0");
            //Console.WriteLine(obj.solution(0, 0, 0));
            Console.WriteLine("One in Minus 0: A=-1,B=10,C=5");
            Console.WriteLine(obj.solution(-1, 10, 5));
            Console.ReadLine();
        }
        
    }
}
