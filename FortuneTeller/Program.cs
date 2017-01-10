using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Please enter a number:");
            // int score = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello user! What is your first name?");

            string firstName = (Console.ReadLine());

            Console.WriteLine("What is your last name?");

            string lastName = (Console.ReadLine());

            Console.WriteLine("How old are you?");

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your birth month?");

            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV is, type \"Help\"");

            string favoriteColor = Console.ReadLine();


            if (favoriteColor == "Help" )
            {
                Console.WriteLine("ROYGBIV are the colors:");
                Console.WriteLine("Red");
                Console.WriteLine("Orange");
                Console.WriteLine("Yellow");
                Console.WriteLine("Green");
                Console.WriteLine("Blue");
                Console.WriteLine("Indigo");
                Console.WriteLine("Violet");
                Console.WriteLine("What is your favorite ROYGBIV color?");
                favoriteColor = Console.ReadLine(); 
                }
            
            else
            {
                
            }


            Console.WriteLine("How many siblings do you have?");
            int numberOfSibling = int.Parse(Console.ReadLine());

            //Console.WriteLine(firstName + " " + lastName + " " + age + " " + birthMonth + " " + favoriteColor + " " + numberOfSibling); 

            string retire;

            if (age % 2 == 0)
            {
                retire = "5 years";
            }

            else
            {
                retire = "15 years";
            }


            string vacationHome;

            if (numberOfSibling == 0)
            {
                vacationHome = "Hawaii";
            }

            else if (numberOfSibling == 1)
            {
                vacationHome = "Paris";
            }

            else if (numberOfSibling == 2) 
            {
                vacationHome = "Los Angeles";
            }

            else if (numberOfSibling == 3)
            {
                vacationHome = "New York";
            }

            else if (numberOfSibling > 3)
            {
                vacationHome = "Miami";
            }

            else
            {
                vacationHome = "The hood of Detroit";
            }


            string transportation;

            if (favoriteColor == "Red")
            {
                transportation = "Ferrari";
            }

            else if (favoriteColor == "Orange")
            {
                transportation = "lamborghini";
            }

            else if (favoriteColor == "Yellow")
            {
                transportation = "Mclaren";
            }

            else if (favoriteColor == "Green")
            {
                transportation = "Private Jet";
            }

            else if (favoriteColor == "Blue")
            {
                transportation = "Hellcat Charger";
            }

            else if (favoriteColor == "Indigo")
            {
                transportation = "Paddle boat";
            }

            else if (favoriteColor == "Violet")
            {
                transportation = "Hellicopter";
            }

            else
            {
                transportation = "Walking on your own two feet";
            }
            


            int moneyInBank;

            if (birthMonth >= 9)
            {
                moneyInBank = 10000;
            }

            else if (birthMonth >= 5) 
            {
                moneyInBank = 5000;
            }

            else if (birthMonth >= 1)
            {
                moneyInBank = 1000000;
            }

            else
            {
                moneyInBank = 0;
            }


            //[First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation]

            Console.WriteLine(firstName + " " + lastName + " will retire in " + retire + " with " + moneyInBank + " in the bank, a vacation home in " + vacationHome + " and a " + transportation);





        }
    }
}
