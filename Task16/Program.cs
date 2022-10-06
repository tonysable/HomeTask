string str;
int a;
Console.WriteLine("Введите число от 1 до 7:");
str = Console.ReadLine();
a = Convert.ToInt32(str);
if(a <= 5 && a >= 1){
    Console.WriteLine("Будний день");
}
else if(a >= 6 && a < 8){
    Console.WriteLine("Выходной день");
}
else{
    Console.WriteLine("Нет такого дня недели!");
}