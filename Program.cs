using System;
namespace project
{

     class Program
     {
          static void Main()
          {
               while (true)
               {

                    try
                    {

                         System.Console.WriteLine("\n\n=== КОНСОЛЬНЫЙ КАЛЬКУЛЯТОР === \n\n");
                         double x;
                         System.Console.WriteLine("== ВВЕДИТЕ ПЕРВОЕ ЗНАЧЕНИЕ : ==");
                         x = Double.Parse(Console.ReadLine());

                         string a;
                         System.Console.WriteLine("\n== ВВЕДИТЕ ДЕЙСТВИЕ ==");
                         a = Console.ReadLine();

                         double y;
                         System.Console.WriteLine("\n== ВВЕДИТЕ ВТОРОЕ ЗНАЧЕНИЕ : ==");
                         y = Double.Parse(Console.ReadLine());

                         double result = 0;
                         switch (a)
                         {
                              case "+":
                                   result = x + y;
                                   break;

                              case "-":
                                   result = x - y;
                                   break;

                              case "*":
                                   result = x * y;
                                   break;

                              case "/":
                                   if (y == 0)
                                   {
                                        System.Console.WriteLine("ДЕЛИТЬ НА НОЛЬ НЕЛЬЗЯ !!! ");

                                        continue;

                                   }
                                   result = x / y;

                                   break;

                         }
                         System.Console.WriteLine(" \n\n ВАШ ГРЁБАННЫЙ ОТВЕТ: " + result);
                         System.Console.WriteLine("ВВЕДИТЕ 'надоел' ЧТОБЫ ВЫЙТИ ИЛИ НАЖМИТЕ  'ENTER' ЧТОБЫ ПРОДОЛЖИТЬ ");
                         string exit = Console.ReadLine();
                         if (exit == "надоел")
                              break;
                    }
                    catch (FormatException)
                    {
                         System.Console.WriteLine(" \n\n\n БРАТИШ ТЫ ЧОТО НЕ ТО ВВОДИШЬ , ЗАНОГО СДЕЛАЙ ДА ");


                    }


               }












          }



     }








}










