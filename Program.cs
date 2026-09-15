// int score = = 1200;
// if (score >= 500){
//     Console.WriteLine("Новичок");
// };

// Console.WriteLine("Игра продолжается");

// int movieNumber = int.Parse(Console)
using System.Data;

// int score = 3200;
// int recordScore = 3000;
// string result = (score > recordScore) ?
// "Новый рекорд!" : "Обычный результат!";
// // if (score > recordScore)
// //     result = "Новый рекорд!";
// // else
// //     result = "Обычный результат";
// Console.WriteLine(result);
int age = 15;
if (age >= 21) {
     Console.WriteLine("Доступ разрешён");
 }
 Console.WriteLine("Программа продолжает работу");

int a = 15;
if (a >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещен");
    Console.WriteLine($"Осталось ждать до совершеннолетия: {18 - a} лет");
}

int ag = 58;
if (ag < 13) {
    Console.WriteLine("Ребенок");
} else if (ag < 18){
    Console.WriteLine("Подросток");
} else if (ag < 60){
    Console.WriteLine("Взрослый");
} else {
    Console.WriteLine("Пенсионер");
}

int age3 = 16;
double height = 1.4;
bool hasAdult = true;
if (age3 >= 14 && height >= 1.5 || hasAdult ) {
    Console.WriteLine("Можно кататься");
} else {
    Console.WriteLine("Пока нельзя ");
}