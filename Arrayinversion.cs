public class Arrayinversion
{ 
    public static void start()
    {
        int[] numbers = { 12, 4, 3, -2, 1, 9, 0 };
        int n = numbers.Length;
        int k = n / 2;

        // что ты хотел этим сделать?
        // попытайся сделать алгоритм
        for (int i = 0; i < k; i++)
            ;

        foreach (int i in numbers)
        { 
            Console.WriteLine($"{i} \t");
        } 
    }
} 

//Дан массив из целых чисел [12, 4, 3, -2, 1, 9, 0], напиши программу которая:
//a) выведет элементы в обратном порядке, через запятую.
//б) выведет элементы умноженные на второй элемент
//
//Нельзя использовать Array.Reverse.
//
//Структуру для всех задач в этом проекте делай на подобии Cakes.cs - внутри Start()
