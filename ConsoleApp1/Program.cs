﻿using ConsoleApp1;


internal class Program{
    static void Main(string[] args){
        Console.WriteLine("Hello, World!");
        var a = 2;
        var b = 3;

        Console.WriteLine(a+b);

        AV aV = new AV();
        Console.WriteLine("Average: " + AV.getAverage(new int[] { 2, 6, 2, 5, 80, 74, 123 }));
    }
}