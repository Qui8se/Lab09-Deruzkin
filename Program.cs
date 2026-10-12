// Шаг 1

// int totalExercises = 1;

// for (int number = 8; number >= totalExercises; number--) {
//     Console.WriteLine($"Упражнение {number}");
// }
// Console.WriteLine("Домашнее задание готово");






//Шаг 2

// for (int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }





//Шаг 3

// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// {
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("^_^");
// }





//Шаг 4

// int count = 0;
// for (int ticket = 1; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         count++;
//         continue;
//     }
//     Console.WriteLine($"Первый доступный билет: {ticket}\nБыло пропущено: {count}");
//     break;
// }





//Шаг 5

// for (; ; )
// {
//     Console.Write("Введите код группы (для выхода -'выход'):");
//     string groupCode = Console.ReadLine();

//     if (groupCode == "выход")
//     {
//         break;
//     }
//     Console.WriteLine($"Записан код группы: {groupCode}");
// }
// Console.WriteLine("Работа с журналом завершена");




//Самостоятельные задания 
//Задача A

// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine());

// for (int i = 1; i <= n; i += 2)
// {
//     Console.WriteLine(i);
// }




//Задача Б


// for (int i = 100; i>=0; i -= 10)
// {
//     Console.WriteLine(i);
// }





// задача 6

// int n = 30;
// for(int i = 1; i <= n; i++)
// {
//     if (i % 4 == 0)
//     {
//         continue;
//     }
//     Console.Write(i + " ");
// }





// задача 10

// int n = 6;

// for (int i = 1; i <= 5; i++)
// {
//     for (int j = 1; j <= 5; j++)
//     {
//         if (i + j == n)
//         {
//             Console.WriteLine($"Пара: ({i}, {j})");
//             break;
//         }
//     }
// }

