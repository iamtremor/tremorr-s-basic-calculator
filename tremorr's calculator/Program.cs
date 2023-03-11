// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

class Calculator 
{
    private static void Main(string[] args) 
    {
        int a;
        int b;
        bool isSelected = false;
       
        while (!isSelected) {
            Console.WriteLine("Select a function to perform\n");
            Console.WriteLine("1. Add \n2. Subtract \n3. Multiply \n4. Square \n5. Modulus");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter First Number");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    b = Convert.ToInt32(Console.ReadLine());
                    add(a, b);
                    isSelected = true;
                    break;
                case 2:
                    Console.WriteLine("Enter First Number");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    b = Convert.ToInt32(Console.ReadLine());
                    subtract(a, b);
                    isSelected = true;
                    break;
                case 3:
                    Console.WriteLine("Enter First Number");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    b = Convert.ToInt32(Console.ReadLine());
                    multiply(a, b);
                    isSelected = true;
                    break;
                case 4:
                    Console.WriteLine("Enter Number");
                    a = Convert.ToInt32(Console.ReadLine());
                    square(a);
                    isSelected = true;
                    break;
                case 5:
                    Console.WriteLine("Enter First Number\n");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Number\n");
                    b = Convert.ToInt32(Console.ReadLine());
                    mod(a, b);
                    isSelected = true;
                    break;
                default:
                    Console.WriteLine("Select a valid option");
                    break;
            }
        }
        
      


    }

    public static void add(int a, int b) 
    {
        int sum = a + b;
        Console.WriteLine($"The addition of {a} and {b} is {sum}");
    }
    public static void subtract(int a, int b) 
    {
        int sub = a - b;
        Console.WriteLine($"The subtraction of {a} and {b} is {sub}");
    }
    public static void multiply(int a, int b)
    {
        int multiply = a * b;
        Console.WriteLine($"The multiplication of {a} and {b} is {multiply}");
    }
    public static void square(int a) 
    {
        int square = a * a;
        Console.WriteLine($"The square of {a} is {square}");
    }
    public static void mod(int a, int b) 
    {
        int mod = a % b;
        Console.WriteLine($"The modulus of {a} and {b} is {mod}");
    }
}