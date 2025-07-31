using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BD
{
    class Calculator
    {

        public int Multiply(int a, int b)
        {
            return a * b;
        }


        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }


        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            Console.WriteLine(calc.Multiply(5, 10));
            Console.WriteLine(calc.Multiply(5, 10, 15));
            Console.WriteLine(calc.Multiply(5.5, 10.2));
            Console.Read();
        }
    }
}

    
//        static void Main(string[] args )
//        {
//            //Console.WriteLine("hello  world!");
//            //Console.WriteLine("enter no 1 :");
//            //int a = Convert.ToInt32(Console.ReadLine());
//            //Console.WriteLine("enter no 2 :");
//            //int b = Convert.ToInt32(Console.ReadLine());
//            //int c = a+b;
//            //Console.WriteLine("addtion of the above two no. are :" + c);

//            //Console.WriteLine("Name: Dushyant Dangar");
//            //Console.WriteLine("DOB: 11/03/2005");
//            //Console.WriteLine("Address: 54 , Narayan Nagar");
//            //Console.WriteLine("         Kalawad Road");
//            //Console.WriteLine("City: Rajkot");
//            //Console.WriteLine("Pincode: 360 005");
//            //Console.WriteLine("Country: India");
//            //Console.WriteLine("Email: yd.999017@gmail.com");

//            //tut 1 21
//            //Console.Write("Input the number of terms: ");
//            //int n = int.Parse(Console.ReadLine());

//            //Console.Write("Input number: ");
//            //int num = int.Parse(Console.ReadLine());

//            //int term = 0;
//            //int sum = 0;

//            //Console.WriteLine();
//            //Console.Write("Series: ");

//            //for (int i = 1; i <= n; i++)
//            //{
//            //    term = term * 10 + num;
//            //    sum += term;

//            //    Console.Write(term);
//            //    if (i < n)
//            //        Console.Write(" + ");
//            //}

//            //Console.WriteLine();
//            //Console.WriteLine("The Sum is : " + sum);


//            //tut 1 14
//            //Console.Write("Enter a number: ");
//            //int num = Convert.ToInt32(Console.ReadLine());
//            //int reverse = 0;
//            //int temp = num;

//            //while (temp > 0)
//            //{
//            //    reverse = reverse * 10 + temp % 10;
//            //    temp /= 10;
//            //}
//            //while (reverse > 0)
//            //{
//            //    int digit = reverse % 10;

//            //    if (digit == 0) Console.Write("Zero ");
//            //    else if (digit == 1) Console.Write("One ");
//            //    else if (digit == 2) Console.Write("Two ");
//            //    else if (digit == 3) Console.Write("Three ");
//            //    else if (digit == 4) Console.Write("Four ");
//            //    else if (digit == 5) Console.Write("Five ");
//            //    else if (digit == 6) Console.Write("Six ");
//            //    else if (digit == 7) Console.Write("Seven ");
//            //    else if (digit == 8) Console.Write("Eight ");
//            //    else if (digit == 9) Console.Write("Nine ");
//            //    reverse /= 10;
//            //}

//            //Console.WriteLine();

//            //tut 1 10 write a program which accepts mobile no. as a string from the user and converts the last 5 digits into x. input 1234567890 output 12345xxxxx 

//            // 

//            //Console.Write("Enter a number: ");
//            //int n = Convert.ToInt32(Console.ReadLine());
//            //Console.WriteLine( n + " " + n +" " + n );
//            //for (int i = 1; i <= n; i++)
//            //{
//            //    Console.WriteLine(n + "" + i + " " + n);
//            //}

//            //*
//            //# *
//            //* # * 
//            //# * # *
//            //special patter paresh tanna sir 

//            // array built in functions
//            // int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            //Console.WriteLine("Array Length: " + a.Length);
//            //Console.WriteLine("Array Max: " + a.Max());
//            //Console.WriteLine("Array Min: " + a.Min());
//            //Console.WriteLine("Array Sum: " + a.Sum());
//            //Console.WriteLine("Array Average: " + a.Average());
//            //Console.WriteLine("Array Reverse: " + string.Join(", ", a.Reverse()));

            


//            Console.Read();


//        }
//    }

//}
