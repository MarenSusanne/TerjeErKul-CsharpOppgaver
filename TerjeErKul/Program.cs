for (var index = 0; index < 5; index++)
{
    Console.WriteLine("Terje er kul!");
}

string argus = "Fiddelibom";
foreach (char arg in argus)
{
    Console.WriteLine(arg);
}

bool condition = true;
int i = 1;
while (condition)
{
    if (i < 10)
    {
        Console.WriteLine($"Runde nr {i}");
        i++;
    }
    else
    {
        condition = false;
    }
}