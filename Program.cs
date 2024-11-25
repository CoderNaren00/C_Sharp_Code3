using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Code3 //This is called namespace,only here the  code can be executed.
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //Data types demo1
            byte num1 = 255;
            Console.Write(num1);
            //This is code 2
            short num2 = 32000;
            Console.WriteLine(num2);
            //This is code 3
            int num3 = 250000000; // int can store 9 digit
            Console.Write(num3);
            //This is code 4
            long number = 1234567891011121314; //long int can store 19 digits
            Console.Write(number);
            //This is code 5
            char gender = 'M'; //This will store single character
            Console.Write(gender);
            //This is code for demonstrating stirng
            string Name = "Coder_n";
            Console.Write(Name);
            //This is to demonstrate bool code
            bool status = true;
            Console.Write(status);
            //This code is to  demonstrate float 
            float temperature = 41.2f;
            Console.Write(temperature);
            //This code is to dmostrate double 
            double average = 80.20;
            Console.Write(average);
        }
    }
}
