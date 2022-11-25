int numberOfDay = new Random().Next(1, 8);
if (numberOfDay == 6 || numberOfDay == 7) 
Console.WriteLine($"This number {numberOfDay} stands for day off!");
else Console.WriteLine($"This number {numberOfDay} stands for workday!");