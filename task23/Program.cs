// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число ");
int numeric = Convert.ToInt32(Console.ReadLine());
Print(numeric);


void Print(int numeric)
{
    Console.Write ("Ответ: ");

    for(int k = 1; k <= numeric; k++)
    {
         Console.Write ($"{Math.Pow(k,3)}");
         if(k < numeric) Console.Write (", ");
    }

}

// Почему не работает? НЕ выдает заполненный массив, только одно число

// double cube(int number)
// {
//     double [] result = new double[number];
//     for(int i = 0; i < number; i++)
//     {
//         result[i] = Math.Pow(i,3) ;
//     }
//             
//     return result[]; 
// }


