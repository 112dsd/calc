    int num1 = 0; int num2 = 0;

    Console.WriteLine("Первое число");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Второе число");
    num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("\tw - Плюс");
    Console.WriteLine("\ta - минус");
    Console.WriteLine("\ts - Умножить");
    Console.WriteLine("\td - Разделить");
    Console.Write("Вы выбрали ");

    switch (Console.ReadLine())
    {
        case "w":
            Console.WriteLine($"Результат: {num1} + {num2} = " + (num1 + num2));
            break;
        case "a":
            Console.WriteLine($"Результат: {num1} - {num2} = " + (num1 - num2));
            break;
        case "s":
            Console.WriteLine($"Результат: {num1} * {num2} = " + (num1 * num2));
            break;
        case "d":
            Console.WriteLine($"Результат: {num1} / {num2} = " + (num1 / num2));
            break;
    }
    // Wait for the user to respond before closing.
    Console.Write("Нажмите кнопку что бы выключить");
    Console.ReadKey();