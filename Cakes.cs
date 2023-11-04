public class Cakes
{
    public static void Start()
    {
        // 0 Создать цены и название всех тортов
        string[] cakeNames = { "Торт95", "Тортик", "Тортище" };
        int[] cakesPrices = { 3600, 1507, 200 };

        //1 Вывести текст (Муьлха торт еза хьуна?;)
        Console.Write("Муьлха торт еза хьуна?: ");

        //2 Получить название торта
        //3 Сохранить название торта
        string otvetpozovatelya = Console.ReadLine();

        //4 Сравнить название торта с имеюшимися тортами
        if (otvetpozovatelya == cakeNames[0])
        {
            Console.WriteLine($"{cakesPrices[0]} сом доьху");
        }
        else if (otvetpozovatelya == cakeNames[1])
        {
            Console.WriteLine($"{cakesPrices[1]} сом доьху");
        }
        else if (otvetpozovatelya == cakeNames[2])
        {
            Console.WriteLine($"{cakesPrices[2]} сом доьху");
        }
        else
        {
            Console.WriteLine($"{otvetpozovatelya} йяц, нету давай досвидания");
        }
    }
}
