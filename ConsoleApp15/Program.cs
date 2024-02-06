using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //заданиие 1 
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write($"A"+" ");
            //}

            //задание 2 
            //for (int i=50;i>=40;i--)
            //{
            //    Console.WriteLine(i);
            //}

            //задание 3
            //for (int a=1;a<=6;a++)
            //{
            //    int number =6*a;
            //    if (number > 36)
            //        break;
            //    Console.Write(number+" ");
            //}

            //задание 4
            //int count = 0;
            //for (int i = 10; i <= 99; i++)
            //{
            //    if (i%11==0)
            //    {
            //        Console.WriteLine(i);
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Количество этих чисел = {count}") ;

            //задание 5
            //int count = 0;
            //for (int i=100;i<=999;i++)
            //{
            //    int a = i / 100;
            //    int b = i % 10;
            //    int c = (i / 10) % 10;
            //    if (a+b+c==20)
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine($"Количество этих чисел = {count}");

            //задание 6
            //Console.Write("Введите сумму вклада : ");
            //double deposit = double.Parse(Console.ReadLine());
            //Console.Write("Введите количество месяцов : ");
            //int month = int.Parse(Console.ReadLine());
            //double percent = 0.07;
            //double profit = 0;
            //double price = 0;
            //double rev = 0;
            //for (int i = 1; i <= month; i++)
            //{
            //    price = deposit * Math.Pow(1 + percent,i);
            //    Console.WriteLine($"{i} месяцов = {price:F2} руб");
            //    profit += price; 
            //    rev += price;
            //}
            //double profit2 = deposit*Math.Pow(1+percent, month);
            //profit =price-deposit;
            //Console.WriteLine($"заработано за {month} месяцеов = {profit:f2}\nконечная сумма на счету за {month} месяцов = {profit2:f2}\nоборот на счету за {month} месяцов составит:{rev:f2} ");

            //задание 7
            //double initialPrice = 100;
            //double growthRate = 0.10;
            //int shares = 1000;
            //Console.WriteLine("Стоимость акции:");
            //for (int month = 1; month <= 12; month++)
            //{
            //    double price = initialPrice * Math.Pow(1 + growthRate, month);
            //    Console.WriteLine($"{month} месяц = {price:F2} руб");
            //}

            //double seventhMonthPrice = initialPrice * Math.Pow(1 + growthRate, 7);
            //double profit = seventhMonthPrice * shares;
            //Console.WriteLine($"Стоимость 1000 акций на 7 месяц = {profit:F2} руб");


            Console.ReadKey();
        }
        
    }
}
