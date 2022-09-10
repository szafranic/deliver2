using System;
using System.Numerics;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Welcome to the Grand Buffet, each person is just $9.99! We only charge extra for coffee. How many people will we be having? We'd apppreciate no more than 6.");
		int party = int.Parse(Console.ReadLine());
		double foodPrice = 9.99;
		double coffeePrice = 1.49;
		int waterCount = 0;
		int coffeeCount = 0;

		if (party <= 6)
		{
			Console.WriteLine("A table for " + party + "! Please follow me and take a seat");
			Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.");
			for (int i = 1; i <= party; i++)
			{
				Console.WriteLine("Alright, person " + i + ", water or coffee?");
				string answer = Console.ReadLine();
				if (answer == "water")
				{
					waterCount++;
					Console.WriteLine("Water for sure.");
				}
				else if (answer == "coffee")
				{
					coffeeCount++;
					Console.WriteLine("Coffee, we make it fresh!");
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
			total = Math.Round(total,2);
			Console.WriteLine("Your total is $" + total +". Please take your time and enjoy!");
		}
		else
		{
			Console.WriteLine("I'm sorry, we don't have any tables to seat more than 6 people. Have a nice day.");
		}
	}
}