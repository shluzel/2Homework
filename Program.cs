﻿Console.Clear();

//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Write ("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Вторая цифра из числа: {a/10%10}" );
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write ("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a<100) {
    Console.Write ("Третьей цифры нет.");
}
else {
    while (a>=1000) {
        a = a/10;
    }
    Console.Write($"Третья цифра из числа: {a%10}" );

}
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write ("Введите день недели (MON=1, TUE=2,.., SUN=7): ");
int a = Convert.ToInt32(Console.ReadLine());
if (a<1 && a>7) {
    Console.Write($"Введен неверный день недели." );
}
else {
if (a==6 || a==7) {
    Console.Write("Введенный день недели является выходным!" );
}
else {
    Console.Write("Введенный день недели не является выходным :(" );
}
}
