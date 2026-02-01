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
      
       switch (a) {

           case "+" : 
            System.Console.WriteLine($"ВАШ ОТВЕТ : {x + y } ");
             break;
           case "-" : 
           System.Console.WriteLine($"ВАШ ОТВЕТ : {x - y } ");
            break;
          case "*" : 
           System.Console.WriteLine($"ВАШ ОТВЕТ : {x * y } ");
            break;
            case "/"  : 
           System.Console.WriteLine($"ВАШ ОТВЕТ : {x / y } ");
            if ( y == 0)
                    {
                       System.Console.WriteLine(" НА НОЛЬ ДЕЛИТЬ НЕЛЬЗЯ!"); 
                    }
                    break; 
            
            }


            


        }


    }
    
}