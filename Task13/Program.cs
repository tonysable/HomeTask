// int a = 1;
// while(a <= 10){
//     Console.WriteLine(a);
//     a += 1;
// }
string str;
long a;
Console.WriteLine("Введите число:");
str = Console.ReadLine();
a = Convert.ToInt32(str);
if(a >= 100){


    long b = 10;
    while(a > b){
        b *= 10;
    }

    Console.WriteLine(a * 1000 / b % 10);
}
else{
    Console.WriteLine("Нет третьего числа");
}