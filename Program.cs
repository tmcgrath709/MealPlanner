using System;

namespace MealPlanner
{
    class Program
    {
        static void Main(string[] args)

        {
            //Use a while loop to return to the main menu when complete......
            while (true)
            {
                Console.WriteLine("What Would you like to do?");
                Console.WriteLine("1. Add Meal Entry");
                Console.WriteLine("2. View Meal History");
                Console.WriteLine("3. View Foods");
                string answer = Convert.ToString(Console.ReadLine());

                if (answer == "1")
                {
                    AddEntry();

                }
                else if (answer == "2")
                {
                    ViewMeal();
                }
                else if (answer == "3")
                {
                    ViewFoods();
                }
            }

        }

        //Method for "1. Add Meal Entry"
        static void AddEntry() 
        {
            //ask for 'when' and get the answer
            Console.Write("When: ");
            var when = Console.ReadLine();
            Console.Write("");


            //ask for 'foods' and get the answer
            Console.Write("Foods: ");
            var mealplanfood = new System.Collections.Generic.List<string>();
            var food = Console.ReadLine();
            var foods = food.Split(",");
            Console.Write("");

            //ask for 'cals' and get the answer
            Console.Write("Calories: ");
            var cals = Console.ReadLine();
            Console.WriteLine("");

            //display the answer back to the user
            Console.WriteLine("Your last meal was " + when + " it contained the following foods:" + food + " It had " + cals + " calories in it");


        }



        //Method for 2. View Meal History
        static void ViewMeal()
        {
            Console.WriteLine("...");
        }

        //Method for "3. View Foods"
        static void ViewFoods()
       
        {
            Console.WriteLine("You're Foods are: ");
        }

        public void CalculateCalories()
        {
            //get all the foods eaten for a meal

            //total up all the calories

            //return the total calorie count to the user

        }

       
    }
}
