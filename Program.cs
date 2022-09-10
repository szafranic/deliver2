using System;
using System.Numerics;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");
		int party = int.Parse(Console.ReadLine());
		double foodPrice = 9.99;
		double coffeePrice = 2.99;
		int waterCount = 0;
		int coffeeCount = 0;

		if (party <= 6)
		{
			Console.WriteLine("A table for " + party + "! Please follow me and take a seat");
			Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.");
			for (int i = 1; i < party; i++)
			{
				Console.WriteLine("Alright, person number " + i + ", water or coffee?");
				string answer = Console.ReadLine();
				if (answer == "water")
				{
					waterCount++;
					Console.WriteLine("Water for sure.");
				}
				else if (answer == "coffee")
				{
					coffeeCount++;
					Console.WriteLine("Coffee, we make it fresh.");
				}
				else
				{
					Console.WriteLine("We don't serve that here");
				}
			}
			Console.WriteLine("Okay, so that's " + coffeeCount + " coffees and " + waterCount + " waters. I'll be right back. Feel free to grab your food!");

			foodPrice *= party;
			coffeePrice *= coffeeCount;
			double total = foodPrice + coffeePrice;

			Console.WriteLine("your total is $" + total);


		}

		else
		{
			Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
		}
	}

}