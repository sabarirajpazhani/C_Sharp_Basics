using System;
using System.Diagnostics;

namespace C_Sharp_Basics {
    public class Program
    {
        public static void dataTypes() { 
            int num = 5;
            char letter = 's';
            double myNum = 6.99D;
            float floatNum = 123.0f;
            bool boolean = true;
            string str = "Hello Developers";


            Console.WriteLine(num);
            Console.WriteLine(letter);  
            Console.WriteLine(myNum);
            Console.WriteLine(floatNum);    
            Console.WriteLine(boolean);
            Console.WriteLine(str);
        }

        public static void Variables()
        {
            int num = 100;
            Console.WriteLine(num);

            Console.WriteLine("User Given Input Or getting Input from User");
            Console.WriteLine("Enter any Integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);

            Console.WriteLine("Enter Any String: ");
            string str = Console.ReadLine();    
            Console.WriteLine(str);

            Console.WriteLine("Enter any float value: ");
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine(f);

            Console.WriteLine("Enter any long value: ");
            long myLong = long.Parse(Console.ReadLine());
            Console.WriteLine(myLong);

            Console.WriteLine("Enter any Double value: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine(d);

            Console.WriteLine("Enter any Boolean value: ");
            bool boolean = bool.Parse(Console.ReadLine());
            Console.WriteLine(boolean);
        }

        static void TypeConversion()
        {
            //Implicit Type conversion
            Console.WriteLine("Implicit Type conversion");
            int num = 10;
            long numLong = num;
            Console.WriteLine(numLong);
            Console.WriteLine(numLong.GetType());

            Console.WriteLine("Explicit Type Conversion");
            long number = 2312354;
            int myNum = (int)number;
            Console.WriteLine(myNum);
            Console.WriteLine(myNum.GetType());


            Console.WriteLine("Type Conversion");
            int numInt = 100;
            double doubNum = 5.35;
            bool b = true;

            Console.WriteLine(Convert.ToDouble(numInt));
            Console.WriteLine(Convert.ToString(doubNum));
            Console.WriteLine(Convert.ToString(b));
        }

        public static void Operators()
        {
            Console.WriteLine("Arithmatic Operator");
            int x = 10;
            int y = 20;
            Console.WriteLine("Addition");
            Console.WriteLine(x + y);
            Console.WriteLine("Subtration");
            Console.WriteLine(x - y);
            Console.WriteLine("Multiplicaton");
            Console.WriteLine(x * y);
            Console.WriteLine("Division");
            Console.WriteLine(x / y);
            Console.WriteLine("Modulus");
            Console.WriteLine(x % y);

            Console.WriteLine("Relational Operators");
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x <= y);

            Console.WriteLine("Logical Operators");
            bool b1 = true;
            bool b2 = false;
            Console.WriteLine(b1 || b2);
            Console.WriteLine(b2 && b2);
            Console.WriteLine(!b1);

            Console.WriteLine("Assignment Operators");
            int a = 3;
            a += 5;
            Console.WriteLine(a);
            a -= 1;
            Console.WriteLine(a);
            a *= 2;
            Console.WriteLine(a);
            a /= 2;
            Console.WriteLine(a);
            a %= 4;
            Console.WriteLine(a);

            Console.WriteLine("Increment/Decrement Operators");
            int b = 10;
            b++;
            Console.WriteLine(b);
            ++b;
            Console.WriteLine(b);
            --b;
            Console.WriteLine(b);
            b--;
            Console.WriteLine(b);

            Console.WriteLine("Ternary Operator");
            int num1 = 10;
            int num2 = 20;
            string str = (num1 > num2) ? "num1 is greater" : "num2 is greater";
            Console.WriteLine(str);

        }
        static void Main(String[] args)
        {
            dataTypes();
            Console.WriteLine("--------------------------------");
            Variables();
            Console.WriteLine("--------------------------------");
            TypeConversion();
            Console.WriteLine("--------------------------------");
            Operators();



        }
    }
}