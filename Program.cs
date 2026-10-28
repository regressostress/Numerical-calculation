Console.WriteLine("Добро пожаловать в (ваши затраты)! ");
Console.WriteLine("Нажмите Enter для продолжения...");
Console.ReadKey();
int[] summ = new int[5];
while (true)
{
    
Console.WriteLine("Введи свои траты за 5 дней: ");
    
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("День: " + (i+1));
        summ[i] = Convert.ToInt32(Console.ReadLine());
    }
    int sum = 0;
    for(int i = 0;i < 5; i++)
    {
        sum += summ[i];
    }
    Console.WriteLine("Вся сумма затрат: " + sum);
    int maxSum = summ[0];
    for (int i = 0; i < 5; i++)
    {
        if (summ[i] > maxSum)
        {
            maxSum = summ[i];
        }
    }
    Console.WriteLine("Самая большая трата за день: " +  maxSum);
    Console.WriteLine("Введите Enter для продолжения...");
    Console.ReadLine();
}
