Console.Write("Введи целое число: ");
int numberA = int.Parse(Console.ReadLine());
switch (numberA)
{
    case 1: 
    Console.Write("Сегодня понедельник ");
        break;
      
      case 2: 
    Console.Write("Сегодня вторник ");
        break;
    
      case 3: 
    Console.Write("Сегодня среда ");
        break;

      case 4: 
    Console.Write("Сегодня четверг ");
        break;

      case 5: 
    Console.Write("Сегодня пятница ");
        break;    

      case 6: 
    Console.Write("Сегодня суббота ");
        break;

      case 7: 
    Console.Write("Сегодня воскресенье ");
        break;    
    
    default:
    Console.Write("game over, попробуй снова нажми срелку вверх и интер ");
     break;

}
