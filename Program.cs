int exitChoice = 1;

while (exitChoice == 1)
{
    double underweight = 18.5;
    double normalBodyWeight = 24.9;
    double overweight = 25;
    int obesity = 30;

    Console.WriteLine("Эй, парень, какой у тебя рост?:");
    float height = float.Parse(Console.ReadLine());
    float heightInMeters = height / 100f;

    Console.WriteLine("Признавайся, какой тебя вес? Да не боись, свои же!");
    float weight = float.Parse(Console.ReadLine());

    float bmi = weight / (heightInMeters * heightInMeters);

    if (bmi <= underweight)
    {
        Console.WriteLine($"Индекс массы твоего тела составляет {bmi}. Оцениваю его как 'недостаточное'.");
    }
    else if (bmi <= normalBodyWeight && bmi < overweight)
    {
        Console.WriteLine($"Индекс массы твоего тела составляет {bmi}. Оцениваю его как 'нормальное'.");
    }
    else if (bmi > overweight && bmi < obesity)
    {
        Console.WriteLine($"Индекс массы твоего тела составляет {bmi}. Оцениваю его 'избыточная'. Крайне рекомендую сократить порции в своем рационе. Ведь как говорят: от избыточной массы тела до ропухи - один пирожок.");
    }
    else if (bmi >= obesity)
    {
        Console.WriteLine($"Индекс массы твоего тела составляет {bmi}. Оцениваю его как 'ожирение'. Ох и ропуха же ты! Небось в дверные проемы не влезаешь?");
    }
    
    Console.WriteLine("Если желаешь посмотреть в зеркало ещё раз, нажми цифру '1' на клавиатуре, если стало стыдно и решил уйти - нажми цифру '0' на клавиатуре. Выбор за тобой.");
    exitChoice = Convert.ToInt32(Console.ReadLine());
}