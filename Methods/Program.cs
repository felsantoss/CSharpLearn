int[] array = { 0, 1, 2, 3, 4, 5 };

Console.WriteLine("Contents of Array");

PrintArray();

void PrintArray()
{
	foreach (int value in array)
	{
		Console.Write($"{value} ");
	}
	Console.WriteLine();
}

Console.WriteLine("Generate random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
	Random random = new Random();

	for (int i = 0; i < 5; i++)
	{
		Console.Write($"{random.Next(1, 100)} ");
	}

	Console.WriteLine("Do you wanna print again? y/n");
	var answer = Console.ReadLine();

	if (answer == "y")
	{
		DisplayRandomNumbers();
	}
	else if (answer == "n")
	{
		Console.Clear();
	}
	else
	{
		Console.WriteLine("Lyrics do not regonize.");
	}
}

Console.Clear();

int[] times = { 800, 1200, 1600, 2000 };
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

/* Format and display medicine times */
DisplayTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
	Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
	diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

	/* Adjust the times by adding the difference, keeping the value within 24 hours */
	AdjustTimes();
}
else
{
	diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

	/* Adjust the times by adding the difference, keeping the value within 24 hours */
	AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");

/* Format and display medicine times */
DisplayTimes();

void DisplayTimes()
{
	foreach (int value in times)
	{
		string time = value.ToString();
		int length = time.Length;

		if (length >= 3)
		{
			time = time.Insert(length - 2, ":");
		}
		else if (length == 2)
		{
			time = time.Insert(0, "0:");
		}
		else
		{
			time = time.Insert(0, "0:0");
		}

		Console.Write($"{time} ");
	}
}

void AdjustTimes()
{
	for (int i = 0; i < times.Length; i++)
	{
		times[i] = ((times[i] + diff)) % 2400;
	}
}

Console.Clear();

TellFortune();

void TellFortune()
{
	Random random = new Random();
	int luck = random.Next(100);

	string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
	string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
	string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
	string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

	Console.WriteLine("A fortune teller whispers the following words:");
	string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
	for (int i = 0; i < 4; i++)
	{
		Console.Write($"{text[i]} {fortune[i]} ");
	}
}

Console.ReadKey();	