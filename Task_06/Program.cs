/*
    Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
    является ли число чётным (делится ли оно на два без остатка).
    4 -> да
    -3 -> нет
    7 -> нет
*/

int num;
string strLine;

Console.Write("Number: ");
strLine = Console.ReadLine();
num = int.Parse(strLine);

if(num % 2 == 0){
    // четное
    Console.WriteLine("Even number");
}
else{
    // нечетное
    Console.WriteLine("Uneven number");
}