﻿int[] schedule = { 800, 1200, 1600, 2000 };

Console.Clear();

string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

double pi = 3.14159;

PrintCircleInformation(12);
PrintCircleInformation(24);

void PrintCircleInformation(int radius)
{
	Console.WriteLine($"Circle with radius {radius}");
	PrintCircleArea(radius);
	PrintCircleCircumference(radius);
}

void PrintCircleArea(int radius)
{
	double area = pi * (radius * radius);
	Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
	double circumference = 2 * pi * radius;
	Console.WriteLine($"Circumference = {circumference}");
}

void DisplayStudents(string[] students)
{
	foreach (string student in students)
	{
		Console.Write($"{student}, ");
	}
	Console.WriteLine();
}
void CountTo(int max)
{
	for (int i = 0; i <= max; i++)
	{
		Console.Write($"{i}, ");
	}
}

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
	int diff = 0;

	if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
	{
		Console.WriteLine("Invalid GMT.");
	}
	else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
	{
		diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
	}
	else
	{
		diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
	}

	for (int i = 0; i < times.Length; i++)
	{
		int newTime = ((times[i] + diff)) % 2400;
		Console.WriteLine($"{times[i]} -> {newTime}");
	}
}

Console.ReadKey();