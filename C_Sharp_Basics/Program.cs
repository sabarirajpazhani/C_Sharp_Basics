using System;

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
        static void Main(String[] args)
        {
            dataTypes();
            Console.WriteLine("--------------------------------");
            Variables();
            Console.WriteLine("--------------------------------");

        }
    }
}