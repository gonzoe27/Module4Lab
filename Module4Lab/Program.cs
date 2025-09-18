using System;

namespace Module4Lab
{
    class Program
    {
        //Main method - entry point to your app 
        static void Main(string[] args)
        {
            //Output a greeting 
            Console.WriteLine("⭐ Welcome to Como Park Zoo 🌟");
            Console.WriteLine("===============================");

            //First, simple array example
            Console.WriteLine("Here are some animals we already have: ");
            string[] sampleAnimals = { "Sea Lion", "Giraffe", "Lemur", "Polar Bear" };

            //Use a for loop to iterate aka walk through 
            //++ opererator that increments the vaule of a variable by one 
            // i++ that is the same as i = i + 1
            for (int i = 0; i < sampleAnimals.Length; i++)
            {
                //Print the name of the current animal in the array
                Console.WriteLine($"- {sampleAnimals[i]}");
            }// end of loop

            Console.WriteLine("\nNOw lets add your animals to the como Zoo!/n");

            //use a while loop to get valid input
            Console.Write("How many animals do you want to add: ");

            //Holds the numbeer of animals 
            int numberofAnimals;

            //Use a while loop when are't 
            while (!int.TryParse(Console.ReadLine(), out numberofAnimals) || numberofAnimals <= 0)
            {
                Console.Write("Please enter a number greater than 0: ");
            }//end while loop 

            //Create an array to store the animals and make it is size equal to 
            // the number of animals the user wanted to add to the zoo
            string[] animals = new string[numberofAnimals];

            // use a for loop to collect animal names
            for (int i = 0; i < numberofAnimals; i++)
            {
                Console.Write($"Enter animal # {i + 1}: ");
                animals[i] = Console.ReadLine();
            }// end for loop 

            //Display tej animals using another for loop
            Console.WriteLine("\nYour new Como Zoo Animals: ");
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {animals[i]}");
            }// end of for loop

            //Output a closing message 
            Console.WriteLine($"\nYou  added {animals.Length} animals into Como Zoo!");


        }//end main method 
    }//end class
}// end namespace 