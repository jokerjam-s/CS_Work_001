/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    2 3 7 -> 7
    44 5 78 -> 78
    22 3 9 -> 22
*/

// реализация без массивов


int n1, n2, n3;
string strLine;

Console.Write("Number 1: ");
strLine = Console.ReadLine();
n1 = Convert.ToInt32(strLine);

Console.Write("Number 2: ");
strLine = Console.ReadLine();
n2 = Convert.ToInt32(strLine);

Console.Write("Number 3: ");
strLine = Console.ReadLine();
n3 = Convert.ToInt32(strLine);


if((n1 >= n2) && (n1 >= n3)){
    Console.WriteLine("Max = "+ n1);
}
else if((n2 >= n1) && (n2 >= n3)){
    Console.WriteLine("Max = "+ n2);
}
else{
    Console.WriteLine("Max = "+ n3);
}