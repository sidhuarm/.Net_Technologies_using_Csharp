using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpFundamentalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;        // Integer Type
            int counter1;
            counter1 = 2;           
            long numberOfBytes = 10001;         // long type
            double rate = 5.25;                 // double
            float interest = 1.5F;               // must hav F or f at last
            decimal total = 24177.55m;            // Decimal type (not in java)|Must be specified wit  M or m.
            char character = 'c';
            bool flag = true;
            int x = 3, y = 5;  // defining & initializing multiple variables
            const double RATE = 55.5;  // defining constant which is similar in java.
            //We can use fixed words as variables by putting @ infront of them
            int @case = 50;
            string msg = "Sheridan"; // string initialization
            string msg1 = "";
            string msg2 = null;
            string rateString = "Rate =" + rate; // ************** rate will be converted to string and then they will be concatenated. means string rateString = "Rate =" + "5.25";(value of rate)

            // Type Reference
            var anyTypee = "Arman";  // means when u dont know what will be the vaule, we can use var type and according to value, datatype will be selected
            var salary = 44.51; 
            // once var type variable is given value and u cannot change type i.e once anyType is string. so , u cant change to int in next line.




            Console.WriteLine(counter);
            Console.WriteLine(counter1);
            Console.WriteLine(rate);
            Console.WriteLine(interest);
            Console.WriteLine(RATE);
            Console.ReadKey();
        }
    }
}
