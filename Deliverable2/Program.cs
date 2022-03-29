using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
 
            {
                bool continueQuestion = true;
                while (continueQuestion)
                {
                    bool valid = false;
                    int coffeeCounter = 0;
                    int waterCounter = 0;

                    while (!valid)
                    {
                        Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge an extra $2 for coffee."
                            + " How many people are in your group? Please, parties of 6 or lower.");
                        int userinput = int.Parse(Console.ReadLine());

                        if (userinput >= 1 && userinput <= 6)
                        {
                            Console.WriteLine();
                            Console.WriteLine("A table for " + userinput + "! Please follow me and take a seat.");
                            Console.WriteLine("Let's get everyone started with some drinks. We've got water and coffee.");
                            valid = true;
                            Console.WriteLine();

                        for (int numberofguest = 1; numberofguest <= userinput; numberofguest++)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Alright, person number " + numberofguest + ", water or coffee?");
                                string input = Console.ReadLine();
                                Console.WriteLine();

                                string[] items = { "coffee", "water" };
                                
                                if (input.ToLower() == "coffee" || input.ToLower() == "water")
                                {
                                    if (input.ToLower() =="coffee")
                                    {
                                        coffeeCounter++;
                                    }
                                    else if (input.ToLower() == "water")
                                    {
                                        waterCounter++;
                                    }


                                    Console.WriteLine("Okay " + input + ", good choice.");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    string message = "Sorry, thats not on the menu.";
                                    Console.WriteLine(message);
                                    Console.WriteLine();
                                    continueQuestion = false;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Unfortunatly, we can only seat parties up to 6. Sorry.");
                            Console.WriteLine();
                            continueQuestion = false;
                            break;
                        }
                        if (userinput >= 1 && userinput <= 6)
                        {
                            double buffetPrice = 9.99;
                            double coffeePrice = 2;
                            double waterPrice = 0;
                            double totalBuffet = buffetPrice * userinput;
                            double totalWater = waterPrice * waterCounter;
                            double totalCoffee = coffeePrice * coffeeCounter;
                            double totalBillDue = (totalWater + totalCoffee + (totalBuffet));

                            Console.WriteLine("Okay, so we have " + coffeeCounter + " coffees and " + waterCounter + " waters."
                                + " I'll be right back. Help yourself to the buffet!");
                            Console.WriteLine();
                            Console.Write("Here is your bill. Your total is $" + totalBillDue + ". Have a good day!");
                            Console.WriteLine();
                            continueQuestion = false;
                            break;
                        }
                    }
                }
            }
        }
    }
}