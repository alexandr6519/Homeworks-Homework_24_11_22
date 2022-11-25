Console.WriteLine("Please, input the integer number!");
int number = Convert.ToInt32(Console.ReadLine());
int numberAbs = Math.Abs(number);
double degree = Math.Log10(d: numberAbs);

if (degree < 2)
{
    Console.WriteLine("Inputing number has no the theird digital!");
}
else
{
    int d = (int)Math.Pow(x: 10, y: (int)(degree) - 2);
    int result = (numberAbs / d) % 10;
    Console.WriteLine($"Inputing number has the theird digital is {result}!");
}

