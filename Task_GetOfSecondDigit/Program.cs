int numberThreeGigit = new Random().Next(100, 1000);
int result = (numberThreeGigit/10) % 10;
Console.WriteLine($"The second digit of number {numberThreeGigit} is {result}!");