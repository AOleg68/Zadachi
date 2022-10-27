//По заданному номеру дня недели вывести его название

//int a = 1;
//int b = 2;
//int c = 3;
//int d = 4;
//int e = 5;
//int f = 6;
//int g = 7;


Console.Write ("Введите номер дня недели:    ");
string username = Console.ReadLine();

if (username.ToLower() == "1")
{ Console.WriteLine ("Понедельник"); }

if (username.ToLower() == "2")
{ Console.WriteLine ("Вторник"); }

if (username.ToLower() == "3")
{ Console.WriteLine ("Среда"); }

if (username.ToLower() == "4")
{ Console.WriteLine ("Четверг"); }

if (username.ToLower() == "5")
{ Console.WriteLine ("Пятница"); }

if (username.ToLower() == "6")
{ Console.WriteLine ("Суббота"); }

if (username.ToLower() == "7")
{ Console.WriteLine ("Воскресенье"); }

