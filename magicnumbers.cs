public static class MagicNumbers
{
    public static void Start()
    {
        Random randomizer = new Random();
        // создаем массив из 20 элементов
        int[] massivSluchChisel = new int[20];

        // заполняем случайными числами
        for (int i = 0; i < massivSluchChisel.Length; i++)
        {
            massivSluchChisel[i] = randomizer.Next(1,101);
        }
        // отоброжаем все элементы массива как строку разделенную через запятую 
        Console.WriteLine(string.Join(",", massivSluchChisel));
        bool found = false;
        
        // поиск магических чисел
        foreach (int chislo in massivSluchChisel)

        {   // проверка на четность
            bool isEven = (chislo % 2 == 0);
            if (!isEven)
            {
                continue;
            }
            int chisloX2 = chislo * 2;

            // проверяем содержит ли массив текущее число умноженное на 2
            bool containsChisloX2 = massivSluchChisel.Contains(chisloX2);
            if (!containsChisloX2)
            {
                continue;
            }
            found = true;

            Console.WriteLine($"Magic Number = : {chislo} ");
        }
        if (found == false)
        {
            Console.WriteLine("nety");
        }

    }   



}