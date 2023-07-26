using System.Net.NetworkInformation;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Method_1()
        {
            Console.WriteLine("This will print all numbers from 1000 to -1000.");
            for (int i = 1000; i <= 1000 && i >= -1000; i--)
            {
                Console.WriteLine($"{i}")
; }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Method_2()
        {
            for (int i = 3; i >= 3 && i <= 999; i += 3)
            {
                Console.WriteLine($"{i}");
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void Method_3(int a, int b)
        {
           
            if (a == b)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void Method_4(int num)
        {
            
            var equalOrOdd = (num % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(equalOrOdd);

        }
        //Write a method to check whether a given number is positive or negative
        public static void Method_5(int num)
        {

            if (num >= 1)
            {
                Console.WriteLine("Positive");
            }
            else if (num <= -1) 
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Neutral");
            }
        }

        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void Method_6(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote!  Don't make the wrong choice...");
            }
            else
            {
                Console.WriteLine("Sorry kid.  You are gonna have wait a little longer.");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void HeatingUp_1(int num)
        {
            if (num <= 10 && num >= -10)
            {
                Console.WriteLine("Your number is in range");
            }
            else
            {
                Console.WriteLine("Your number is not in range");
            }
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void HeatingUp_2(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {i * num}");
            } 
            
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome!  Which method would you like to select for the Lukewarm exercise? '1', '2', '3', '4', '5', or '6':\nOr for the Heating Up exercises: 11, or 12");
            int select = int.Parse(Console.ReadLine());
            switch(select)
            {
                case 1:
                    Method_1();
                    break;
                case 2:
                    Method_2();
                    break;
                case 3:
                    Console.WriteLine("Enter first number:");
                     var num_1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number:");
                    var num_2 = int.Parse(Console.ReadLine());
                    Method_3(num_1, num_2);
                    break;
                case 4:
                    Console.WriteLine("Enter a number:");
                    var input = int.Parse(Console.ReadLine());
                    Method_4(input);
                    break;
                case 5:
                    Console.WriteLine("Enter a number:");
                    var num = int.Parse(Console.ReadLine());
                    Method_5(num);
                    break;
                case 6:
                    Console.WriteLine("Let's see how old you are... maybe you will be old enough to vote!");
                    Console.WriteLine("Please enter your age.");

                    var age = int.Parse(Console.ReadLine());
                    Method_6(age);
                    break;
                case 11:
                    Console.WriteLine("Enter a number");
                    var range = int.Parse(Console.ReadLine());
                    HeatingUp_1(range);
                    break;
                case 12:
                    Console.WriteLine("Enter a number for a multiplication table");
                    var product = int.Parse(Console.ReadLine());
                    HeatingUp_2(product);
                    break;
                default: Console.WriteLine("Invalid response...");
                    break;
                

                    


            }
             
            
        }
    }
}
