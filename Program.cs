// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");

//Arrays concept in c#

//initializatrion and declaration of array
int[] marks = {85, 90, 78, 92, 88 };

//initializarion using NEW keyword
int[] marks2 = new int[5] { 75, 80, 85, 90, 95 };

//Accessing Array Elements

int[] markss = { 85, 90, 78, 92, 88 };
Console.WriteLine(markss[0]);
Console.WriteLine(markss[3]);

//Modifying Array Elements
int[] marksss = { 85, 90, 78, 92, 88 };
marksss[2] = 80;

//Length of an ARRAY
int[] markssss = { 85, 90, 78, 92, 88 };
Console.WriteLine("Length of the array: " + markssss.Length);



