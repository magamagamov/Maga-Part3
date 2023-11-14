public class Arrayinversion
{ 
    public static void Start()
    {
    int[] array = {12, 4, 3, -2, 1, 9, 0,};
    for (int i = array.Length - 1; i >= 0; --i)
    Console.Write(array[i] + " ");
    Console.ReadKey(true);
    }
} 

//Дан массив из целых чисел [12, 4, 3, -2, 1, 9, 0], напиши программу которая:
//a) выведет элементы в обратном порядке, через запятую.
//б) выведет элементы умноженные на второй элемент
//
//Нельзя использовать Array.Reverse.
//
//Структуру для всех задач в этом проекте делай на подобии Cakes.cs - внутри Start()
