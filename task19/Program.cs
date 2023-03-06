// Задача 19
// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет/1421
// 12821 -> да 12,821/1281
// 23432 -> да

void Paliandrom(int number)
{
   
        if(number / 10000 == number % 10)
            {
             int numberSecond = number / 1000;
             int numberSecondMirror = number / 10;
              if(numberSecond % 10 == numberSecondMirror % 10)
                {
                Console.WriteLine("Число являеться полиандромом");
                }
            }
 
    else Console.WriteLine("Число не являеться полиандромом");
  

}



Console.WriteLine("Введите число");
Paliandrom(Convert.ToInt32(Console.ReadLine()));
