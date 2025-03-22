//Random rand = new Random();
//int length =  rand.Next(0, 100);
//int[] nums = new int [length];
//int[] numsCopy = new int[length];
//int some = 0;   
//for (int y = 0;y < length;y++)
//{
//    some = rand.Next(0, 1000);
//    nums[y] = some;
//    numsCopy[y] = some;

//}

//for (int i = 0; i < nums.Length; i++)
//{
//    nums[i] = rand.Next(0, 100);
//}

//int temp;
//for (int x = 0; x < nums.Length - 1; x++)
//{
//    for (int y = x + 1; y < nums.Length; y++)
//    {
//        if (nums[x] > nums[y])
//        {
//            temp = nums[x];
//            nums[x] = nums[y];
//            nums[y] = temp;
//        }
//    }
//    Console.WriteLine(nums[x]);
//}




double num1;
double num2;
double result;
char oper;
Console.WriteLine("Введите первое число");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите операцию число");
oper = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Введите второе число число");
num2 = Convert.ToDouble(Console.ReadLine());

if (oper == + '+')
{
    result = num1 + num2;
    Console.WriteLine("Cумма " + num1 + " и " + num2 + " равна " + result + ".");

}
else if (oper == '-')
{
    result = num1 - num2;
    Console.WriteLine("Разность " + num1 + " и " + num2 + " равна " + result + ".");
}
else if (oper == '/')
    {
    result = num1 / num2;
    Console.WriteLine("Деление " + num1 + " и " + num2 + " равно " + result + ".");
}
else if (oper == '*')
    {
    result = num1 * num2;
    Console.WriteLine("Умножение " + num1 + " и " + num2 + " равно " + result + ".");
}
else
{
    Console.WriteLine("Неизвестная операция");
}