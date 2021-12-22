using System;

namespace HelloWorld
{
    class Program
    {
        //C# Syntax
        static void Main(string[] args)
        {
            Console.WriteLine("-- EJERCICIOS DE C# DE W3SCHOOLS --\n");

            //C# Comments
            //Comentario de una linea
            /* Comentario
            de
            multiples
            lineas */

            //C# Variables
            Console.WriteLine("> C# Variables");
            int myNum = 50;
            string myName = "Guada";
            Console.WriteLine("\tmyNum: " + myNum);
            Console.WriteLine("\tMyName: " + myName);
            int x = 5;
            int y = 10;
            Console.WriteLine("\tx + y = " + (x + y));
            int z = x + y;
            Console.WriteLine("\tz = " + z);
            int a = 5, b = 6, c = 50;
            Console.WriteLine("\ta + b + c = " + (a + b + c));

            //C# Data Types   
            Console.WriteLine("\n> C# Data Types");
            int myNum1 = 9;
            Console.WriteLine("\tint: " + myNum1);
            double myDoubleNum = 8.99;
            Console.WriteLine("\tdouble: " + myDoubleNum);
            char myLetter = 'A';
            Console.WriteLine("\tchar: " + myLetter);
            bool myBoolean = false;
            Console.WriteLine("\tbool: " + myBoolean);
            string myText = "Hello World";
            Console.WriteLine("\tstring: " + myText);
            bool yay = true;
            bool nay = false;
            Console.WriteLine("\tyay: " + yay + "\tnay: " + nay);
            string greeting = "Hello";
            Console.WriteLine("\tgreeting: " + greeting);
            int myInt = 10;
            Console.WriteLine("\tToString: " + Convert.ToString(myInt));

            //C# User Input   
            /*Console.WriteLine("\n> C# User Input");
            Console.WriteLine("\tEnter username:");
            var userName = Console.ReadLine();
            Console.WriteLine("\tUsername is: " + userName);
            Console.WriteLine("\tThink of a number:");
            int myNum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tYour number is: " + myNum2);*/

            //C# Operators   
            Console.WriteLine("\n> C# Operators");
            Console.WriteLine("\t10 * 5 = " + (10 * 5));
            Console.WriteLine("\t10 / 5 = " + 10 / 5);
            int x1 = 10;
            Console.WriteLine("\tx = " + x1 + "\tx++ --> " + (++x1) + "\tx += 5 -->" + (x1 += 5));

            //C# Math   
            Console.WriteLine("\n> C# Math");
            int x2 = 5;
            int y1 = 10;
            Console.WriteLine("\tMax: " + Math.Max(x2, y1));
            Console.WriteLine("\tSqrt: " + Math.Sqrt(64));
            Console.WriteLine("\tRound: " + Math.Round(2.6));

            //C# Strings
            Console.WriteLine("\n> C# Strings");
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine("\tName: " + name);
            string fullName = $"My full name is: {firstName} {lastName}";
            Console.WriteLine("\t" + fullName);
            string myString = "Hello";
            Console.WriteLine("\tmyString[0]: " + myString[0]);
            string txt = "Hello";
            Console.WriteLine("\ttxt: " + txt + "\tLength: " + txt.Length);
            string txt2 = "Hello World";
            Console.WriteLine("\tToUpper: " + txt2.ToUpper());

            //C# Booleans
            Console.WriteLine("\n> C# Booleans");
            bool isCodingFun = true;
            bool isFishTasty = false;
            Console.WriteLine("\tisCodingFun: " + isCodingFun);
            Console.WriteLine("\tisFishTasty: " + isFishTasty);
            Console.WriteLine("\tx > y ? " + (x > y));

            //C# If...Else
            Console.WriteLine("\n> C# If...Else");
            if (x == y) Console.WriteLine("\tx = y --> 1");
            else if (x > y) Console.WriteLine("\tx > y --> 2");
            else Console.WriteLine("\tx < y --> 3");
            int time = 20;
            string result = (time < 18) ? "\tGood day." : "\tGood evening.";
            Console.WriteLine(result);

            //C# Switch
            Console.WriteLine("\n> C# Switch");
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("\tToday is Saturday");
                    break;

                case 2:
                    Console.WriteLine("\tToday is Sunday");
                    break;

                default:
                    Console.WriteLine("\tLooking forward to the weekend");
                    break;
            }

            //C# Loops
            Console.WriteLine("\n> C# Loops");
            int i = 1;
            Console.Write("\tWhile --> ");
            while (i < 6)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.Write("\n\tDo..While --> ");
            i = 1;
            do
            {
                Console.Write(i + " ");
                i++;
            } while (i < 6);

            Console.Write("\n\tFor --> ");
            for (i = 0; i < 10; i++)
            {
                if (i == 9) break;
                if (i % 2 == 0) continue;
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //C# Arrays
            Console.WriteLine("\n> C# Arrays");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine("\t" + cars[1]);
            cars[0] = "Opel";
            Console.WriteLine("\t" + cars[0]);
            Console.Write("\tForeach --> ");
            foreach (string s in cars)
            {
                Console.Write(s + " ");
            }
            Array.Sort(cars);
            Console.Write("\n\tForeach ordenado --> ");
            foreach (string s in cars)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            //C# Methods
            Console.WriteLine("\n> C# Methods");
            static void MyMethod()
            {
                Console.WriteLine("\tI just got executed!");
            }
            static void MyMethod2(string fname)
            {
                Console.WriteLine("\t" + fname + " Refsnes");
            }
            static int MyMethod3(int x)
            {
                return 5 + x;
            }
            MyMethod();
            MyMethod2("Liam");
            MyMethod2("Jenny");
            MyMethod2("Anja");
            Console.WriteLine("\t" + MyMethod3(3));

            //C# Classes/Objects
            Console.WriteLine("\n> C# Classes/Objects");
            Car ford = new Car(200, "Rojo", "Mustang");
            ford.maxSpeed = 250;
            Console.WriteLine("\t" + ford.color);
            Console.WriteLine("\t" + ford.model);
            ford.fullThrottle();

            //C# Exceptions
            Console.WriteLine("\n> C# Exceptions");
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine("\t" + myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("\tSomething went wrong."+e.HResult);
            }
            finally
            {
                Console.WriteLine("\tThe 'try catch' is finished.");
            }

        }

    }

    class Car
    {
        public int maxSpeed { get; set; }
        public string color { get; set; }
        public string model { get; set; }
        public Car(int maxSpeed, string color, string model)
        {
            this.maxSpeed = maxSpeed;
            this.color = color;
            this.model = model;
        }
        public void fullThrottle()
        {
            Console.WriteLine("\tThe car is going as fast as it can!");
        }
    }
}