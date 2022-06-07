/*

Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8

*/

int num, counter = 1;
string strLine;

Console.Write("Number: ");
strLine = Console.ReadLine();
num = int.Parse(strLine);

if(num <=0){
    Console.WriteLine("Error! Wrong number.");
}
else{
    while(counter <= num){
        if(counter%2 == 0){
            Console.Write(counter + " ");
        }
        counter++;
    }
}
 