Console.WriteLine("Velg et tall mellom 1 - 20");
var input = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine($"Dette er {input}");

Random random = new Random();
var randomNumber = random.Next(1, 20);
if (input > randomNumber)
{
    Console.WriteLine("Dette er for høyt");
}
else if (input < randomNumber)
{
    Console.WriteLine("Dette tallet er for lavt");
}
else
{
    Console.WriteLine("Dette tallet er riktig");
}


