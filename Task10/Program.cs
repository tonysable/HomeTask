string str;
int i;
Console.WriteLine("Введите трёхзначное число:");
str = Console.ReadLine();
i = Convert.ToInt32(str);
int division1 = i / 10;
int division2 = division1 % 10;
Console.Write(division2);
Console.WriteLine(" - вторая цифра числа");
