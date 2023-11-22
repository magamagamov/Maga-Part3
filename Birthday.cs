public static class Birthday
{

    public static void Start()
    {

    Console.Write($" Год вашего рожденья ?");
        int godrojdenie = Convert.ToInt32(Console.ReadLine());
    
    Console.Write($" месяц ");
        int mesyac = Convert.ToInt32(Console.ReadLine());

    Console.Write($" день ");
        int den = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine($" - Поздравляем вам {DateTime.Now.Year - godrojdenie} - лет!");

    Console.WriteLine($" - месяц {DateTime.Now.Month - mesyac}");

    Console.WriteLine($" - День {DateTime.Now.Day - den}");
    }
        //На основе года, месяца и дня рождения пользователя, а также текущей даты, узнать сколько ему полных лет, месяцев и дней.
        //Пример ввода:
        //- Год вашего рождения? 1989
        //- Месяц? 2
        //- День? 9
        //
        //Пример вывода:
        //- Поздравляем! Вам 34 года, 5 месяцев и 3 дня!


}