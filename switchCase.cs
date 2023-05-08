using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace switchCase
{
    
   class program
    {
        public static void Factorial()
        {
            Console.WriteLine("enter the number");
            int num=int.Parse(Console.ReadLine());
         
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact=fact*i;
                    
            }
            Console.WriteLine(fact);
        }
        public static void Prime()
        {
            Console.WriteLine("enter the number");
            int num=int.Parse(Console.ReadLine());
            

            int a = 0;
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                    break;
                }
           
            }
            if(a==0)
            {
                Console.WriteLine("it is the prime number");
            }
            else
            {
                Console.WriteLine("it is not prime");
            }
        }
          public static void fib()
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            
            int a = 0;
            int b = 1;
            Console.WriteLine(a+" "+b);
            for(int i=2; i<num; i++) 
            {
                int c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                 
            }
        }
          public static void Main()
        {
            Console.WriteLine("enter the number");
           Console.WriteLine("1:factorial");
            Console.WriteLine("2:prime");
            Console.WriteLine("3:Fibonacci");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                switch (num)

                {
                    case 1:
                        Factorial();
                        break;


                    case 2:
                        Prime();
                        break;

                    case 3:
                        fib();
                        break;
                    default:
                        Console.WriteLine("wrong value");
                        break;
                }
                Console.WriteLine("enter the option");
                num= int.Parse(Console.ReadLine());

            }
            
            
        }
    }
        
    }























      

