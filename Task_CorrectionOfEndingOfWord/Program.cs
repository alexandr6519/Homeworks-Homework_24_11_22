Console.WriteLine("Please, input the integer positive number!");
int numberOfProgrammers = Convert.ToInt32(Console.ReadLine());
if (numberOfProgrammers < 0)
{
    Console.WriteLine("You inputed the negative number!!! Please, input the integer positive number!");
}
else
{
    Console.Write(numberOfProgrammers);
    int digitSecond;
    if (numberOfProgrammers > 10)
        digitSecond = (numberOfProgrammers / 10) % 10;
    else digitSecond = 0;
    if (numberOfProgrammers % 10 == 2 || numberOfProgrammers % 10 == 3 || numberOfProgrammers % 10 == 4 && digitSecond != 1)
        Console.Write(" программиста");
    else if (numberOfProgrammers % 10 == 1 && digitSecond != 1) Console.Write(" программист");
    else Console.Write(" программистов");
}