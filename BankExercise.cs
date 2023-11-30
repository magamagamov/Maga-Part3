internal class Bank
{
    public static void Start()
    {
        Console.Write("Сумма вклада: ");
        Double summaVklada = Convert.ToDouble(Console.ReadLine());
        
        double summasProcentami;

        if (summaVklada < 100)
        {
            // Если сумма вклада меньше 100, то начисляется 5%.
            summasProcentami = summaVklada * 0.05 + summaVklada;
        }
        else if (summaVklada >= 100 && summaVklada < 200)
        {
            // Если сумма вклада от 100 до 200, то начисляется 7%
            summasProcentami = summaVklada * 0.07 + summaVklada;
        }
        else
        {
            // Иначе 
            summasProcentami = summaVklada * 0.1 + summaVklada;
        }
        
        Console.Write($"Сумма вклада с начисленными процентами:{summasProcentami}");
    }


    //Задача:
    //В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться.
    // Напишите консольную программу, в которую пользователь вводит сумму вклада.
    //  Если сумма вклада меньше 100, то начисляется 5%.
    //   Если сумма вклада от 100 до 200, то начисляется 7%.
    //    Если сумма вклада больше 200, то начисляется 10%.
    //     В конце программа должна выводить сумму вклада с начисленными процентами.
    //Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())
    //Код писать в файле BankExercise1.cs, в методе Start() - на подобии того как ты сделал для Cakes.cs
    //Создай и работай для этой задачи на отдельной ветке. Когда закончишь, сделай Pull Request

    //1.Пользователь вводит сумму вклада.
    //2.Если сумма вклада меньше 100,
}