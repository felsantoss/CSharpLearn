int[] schedule = { 800, 1200, 1600, 2000 };

Console.Clear();

string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

double pi = 3.14159;

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

string[,] corporate =
{
	{"Robert", "Bavin"}, {"Simon", "Bright"},
	{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
	{"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
	{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
	{"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
	DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
	DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
}

void DisplayEmail(string first, string last, string domain = "contoso.com")
{
	string email = first.Substring(0, 2) + last;

	email = email.ToLower();

	Console.WriteLine($"{email}@{domain}");
}

Console.ReadKey();