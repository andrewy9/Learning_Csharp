using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Learning Arrays
            int[] luckyNumbers = { 4, 18, 22, 15, 23, 42 };
            string[] friends = new string[5];
            friends[0] = "Jim";
            int cubedNumber = Cube(4);
            Console.WriteLine(cubedNumber);

            Console.ReadLine();

            //Learning if statement
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are a tall female");
            }
            else
            {
                Console.WriteLine("You are a short female");
            }

            Console.ReadLine();


            //Learning If Statement
            Console.WriteLine(GetMax(100, 1000, 100000));


            Creating a calculator
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if (op == "-")
            {
                Console.Write(num1 - num2);
            }
            else if (op == "*")
            {
                Console.Write(num1 * num2);
            }
            else if (op == "/")
            {
                Console.Write(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
            Console.ReadLine();

            //Learning Switch Statements
            Console.WriteLine(GetDay(5));
            Console.ReadLine();

            //Learning While Loop
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadLine();

            //Learning Do While Loop
            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
            Console.ReadLine();

            Guessing Game
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            //While Loop version
            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.Write("You Lost!");
            }
            else
            {
                Console.Write("You Win!");
            }

            Console.ReadLine();

            Do - While Loop version
            do
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
            } while (guess != secretWord);
            Console.Write("You Win!");

            Console.ReadLine();

            //Learning For-Loop

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.ReadLine();

            //Learning Exponent Method
            Console.WriteLine(GetPow(3, 2));

            //Learning 2d arrays
            int[,] numberGrid = {
               {1, 2 },
               {3, 4 },
               {5, 6 }
            };
            int[,] myArray = new int[2, 3];
            Console.WriteLine(numberGrid[1, 1]);
            

            //Learning Exceptions
            try
            {
                Console.Write("Enter a Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter an another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException err) //gets executed during DivideByZeroException error
            {
                Console.WriteLine(err.Message);
            }
            catch (FormatException err) //gets executed during FormatException error
            {
                Console.WriteLine(err.Message);
            }
            finally //gets executed no matter what
            {
                Console.WriteLine("Thank you.");
            }

            //Learning about class & constructor
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Console.WriteLine(book1.author);

            Book book2 = new Book("Lord Of the Rings", "RR Tolkein", 700);
            Console.WriteLine(book2.author);

            //Learning about class & methods
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            //Learning about getters & setters
            Movies avengers = new Movies("The Avengers", "Joss Wehdon", "PG-15");
            Movies shrek = new Movies("Shrek", "Adam Adamson", "PG");
            Console.WriteLine(avengers.Rating);

            //Learning about Static Class Attributes
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song bytheway = new Song("By the way", "Red Hot Chilli Peppers", 150);
            Console.WriteLine(Song.songCount);

            //Leraning about Static Methods & Classes
            UsefulTools tools = new UsefulTools(); // will have error as the UsefulTools class is static and won't allow creation of new object instances
            Console.WriteLine(Math.Sqrt(144));
            UsefulTools.SayHi("Chuck");
            */

            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();
            Console.WriteLine(chef.name);

            ItalianChef italianchef = new ItalianChef();
            italianchef.MakeChicken();
            italianchef.MakePasta();
            italianchef.MakeSpecialDish();


            Console.ReadLine();
        }

        //Learning Exponentials
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i<powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }


        //Learning Swtich Statements
        static string GetDay(int dayNum) {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }
            return dayName;
        }

        //Learning If Statement
        static int GetMax(int num1, int num2, int num3) {
            if (num1 >= num2 && num1 >= num3)
            {
                return num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }

        }

        //Learning "Return" keyword
        static int Cube(int num) {
            int results = num * num * num;
            return results;
        }

        //Learning basic methods
        static void SayHi(string name, int age) {
            Console.WriteLine("Hello " + name + ", you are " + age);
        }

    }

}
