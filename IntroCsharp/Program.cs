// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using Microsoft.Win32.SafeHandles;

Console.WriteLine("Intro C#");

Console.WriteLine("Entre ton nom");
string name = Console.ReadLine();

Console.WriteLine("Entre ton age");
int age = int.Parse(Console.ReadLine());

if (age < 18)
    Console.WriteLine($"Bonjour {name} vous avez {age} ans tu es mineur");
else
    Console.WriteLine($"Bonjour {name} vous avez {age} ans tu es majeur");