// int score = = 1200;
// if (score >= 500){
//     Console.WriteLine("Новичок");
// };
// else if (score >= 2000) {
//     Console.WriteLine("Боец");
// }
// else {
//     Console.WriteLine("Бонусный уровень закрыт");
// }

//  int movieNumber = int.Parse(Console.ReadLine());
//  string movieGenre;
//  switch(movieNumber){
//     case 1:
//         movieGenre = "Боевик";
//         break;
//     case 2: 
//         movieGenre = "Комедия";
//         break;
//     default:

// }

// int score = 3200;
// int recordScore = 3000;
// string result = (score > recordScore) ?
// "Новый рекорд!" : "Обычный результат!";
// // if (score > recordScore)
// //     result = "Новый рекорд!";
// // else
// //     result = "Обычный результат";
// Console.WriteLine(result);
using System.Globalization;
using System.Threading.Tasks.Dataflow;

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

int ag = 60;
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
//switch
Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine());
string dayName;
switch (day) {
    case 1:
        dayName = "Понедельник";
        break; 
    case 2: 
        dayName = "Вторник";
        break;
    default:
        dayName = "Другой день";
        break;
}
Console.WriteLine($"День недели: {dayName}");

// тернарный оператор
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
string result = (number % 2 == 0) ? "чётное" : "нечётное";
Console.WriteLine($"Число - {result}");

//Самостоятельные задания
Console.WriteLine();
Console.WriteLine("Задача Б");
Console.WriteLine("Введите оценку (число от 2 до 5): ");
int grade = int.Parse(Console.ReadLine());
string words;

switch (grade){
    case 5:
        words = "Отлично";
        break;
    case 4:
        words = "Хорошо";
        break;
    case 3:
        words = "Удовлетворительно";
        break;  
    case 2:
        words = "Неудовлетворительно";
        break;
    default:
    words = "Неверная оценка";
    break; 
}
Console.WriteLine(words);

Console.WriteLine();
Console.WriteLine("Задача В");
Console.Write("Введите первое число: ");
int a1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max;
if (a1>b) {
    max = a1;
} else{
    max = b;
}
if (c>max) {
    max = c;
}
Console.WriteLine($"Наибольшее число: {max}");

Console.WriteLine();
Console.WriteLine("Скидка в магазине (вариант 5)");
Console.Write("Введите сумму покупки: ");

double sum = double.Parse(Console.ReadLine());

double percent = 0;

if (sum > 1000){
    percent = 10;
} else if (sum > 500){
    percent = 5;
} else {
    percent = 0;
}

double totalAmount = sum - (sum * percent / 100);
Console.WriteLine($"Итоговая сумма к оплате: {totalAmount}");
