// 2. Напишите программу, которая будет выдавать название дня
//    недели по заданному номеру.

string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;

int a = int.Parse(s_a);
int b = int.Parse(s_b);

if (a == b * b)  Console.WriteLine("Yes");
else  Console.WriteLine("No");

 // Console.WriteLine("Hello, World!");