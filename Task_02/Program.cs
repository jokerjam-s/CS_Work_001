/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3
*/

/*
    проверку на равенство чисел не производим
*/

int a, b;
string strLine;

Console.Write("input a: ");
strLine = Console.ReadLine();
a = Convert.ToInt32(strLine);

Console.Write("input b: ");
strLine = Console.ReadLine();
b = Convert.ToInt32(strLine);

if(a > b){
    Console.WriteLine("max = " + a);
}
else{
    Console.WriteLine("max = " + b);
}