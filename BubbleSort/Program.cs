




bool Calculate = true;
while (Calculate)
{
    double num1;
    double num2;
    double result;
    char oper;
    Console.WriteLine("Введите первое число");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите  операцию");
    oper = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("Введите второе число число");
    num2 = Convert.ToDouble(Console.ReadLine());
    
    switch (oper)
    {
        case '+':
            result = num1 + num2;
            Calculate = false;
            Console.WriteLine("Cумма " + num1 + " и " + num2 + " равна " + result + ".");
            break;

        case '-':
            result = num1 - num2;
            Console.WriteLine("Разность " + num1 + " и " + num2 + " равна " + result + ".");
            break;

        case '*':
            result = num1 * num2;
            Console.WriteLine("Умножение " + num1 + " и " + num2 + " равно " + result + ".");
            break;

        case '/':
            if (num2 != 0)
            {
                result = num1 / num2;
                Console.WriteLine("Деление " + num1 + " и " + num2 + " равно " + result + ".");
            }
            else
                Console.WriteLine("Ошибка!  Деление на ноль");
            
            break;

        case '%':
            result = num1 % num2;
            Console.WriteLine("Остаток от деления " + num1 + " и " + num2 + " равен " + result + ".");
            break;
             
    }
    Console.WriteLine("Хотите продолжить? (y/n)");
    char reolad = Console.ReadLine()[0];

    if (reolad == 'n' || reolad == 'N')
    {
        Calculate = false;
    }
    else if (reolad == 'y' || reolad == 'Y')
    {
        Calculate = true;
    }
    else
{
    Console.WriteLine("Неизвестная операция");
}

}


