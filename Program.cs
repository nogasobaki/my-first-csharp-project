using System;
namespace projekt{
    
     class Program
    {
       static void Main() 
       { System.Console.WriteLine(" ВВЕДИТЕ ПЕРВОЕ ЗНАЧЕНИЕ : ");
        
        float x;

       x=float.Parse(Console.ReadLine());

       System.Console.WriteLine(" ВВЕДИТЕ ДЕЙСТВИЕ + , - , * , /  ");

       string a; 

       a=Convert.ToString(Console.ReadLine());

       System.Console.WriteLine(" ВВЕДИТЕ ВТОРОЕ ЗНАЧЕНИЕ : ");

       float y;
       
       y=float.Parse(Console.ReadLine());

      if (a == "+") {

          System.Console.WriteLine( $"ВАШ ОТВЕТ : {x + y} "); 
          
          }

          else if ( a == "-")
            {
               System.Console.WriteLine( $"ВАШ ОТВЕТ : {x - y} " ); 

            }
            else if ( a == "*")
            {
                System.Console.WriteLine( $"ВАШ ОТВЕТ : {x * y} ");

            }
            else if (a == "/" && y == 0 )
            {
                
                System.Console.WriteLine(" НА НОЛЬ ДЕЛИТЬ НЕЛЬЗЯ!");
            }



            else if ( a == "/")
            {
                System.Console.WriteLine( $"ВАШ ОТВЕТ : {x / y}" );


            

            }




            


        }


    }
    
}