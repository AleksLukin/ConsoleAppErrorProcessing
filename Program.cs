﻿namespace ConsoleAppErrorProcessing;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.ReadLine();
    }

}
Блоки try инкапсулируют код, формирующий часть нормальных действий программы,
которые потенциально могут столкнуться с серьезными ошибочными ситуациями.
Блоки catch инкапсулируют код, который обрабатывает ошибочные ситуации, происходящие
в коде блока try. Это также удобное место для протоколирования ошибок.
Блоки finally инкапсулируют код, очищающий любые ресурсы или выполняющий другие действия,
которые обычно нужно выполнить в конце блоков try или catch. Важно понимать,
что этот блок выполняется независимо от того,сгенерированo исключение или нет

try и catch
Основу обработки исключительных ситуаций в С# составляет пара ключевых слов try и catch. Эти ключевые 
слова действуют совместно и не могут быть использованы порознь.Ниже приведена общая форма определения блоков 
try/catch для обработки исключительных ситуаций:
try 
{
// Блок кода, проверяемый на наличие ошибок.
}
catch (Тип ошибки1)
{
    // Обработчик исключения для ошибки 1
}
catch (Тип ошибки 2) 
{
    // Обработчик исключения для ошибки 2.
}
