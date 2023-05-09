using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace day4pactice
{
    class Shoping
    {
        int amount;
        String name;
        BankDetail detail = new BankDetail();

        public int Ammount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
                if (amount <=10000)
                {
                    Console.WriteLine("customer is eligible for the shopping");
                    
                }
                else
                {
                    Console.WriteLine("customer is not eligible for the shopping");
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


    }
    class BankDetail
    {
        public void checkEligibility()
        {
            var obj = new Shoping();
            Console.WriteLine("enter your amount");
            int a=int.Parse(Console.ReadLine());
           
            Console.WriteLine("enter your name");
            string b= Console.ReadLine();

            obj.Ammount = a;
            obj.Name = b;

            Console.WriteLine("Customer Amount  is:" + obj.Ammount);
            Console.WriteLine("customer Name is:" + obj.Name);


        }
    }
    class customer
    {
        public static void Main(string[] args)
        {
            var obj = new BankDetail();
            obj.checkEligibility();
            

        }
    }
}
