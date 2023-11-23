internal  class Arrayinversion
{ 
    public static void Start()
    {

//Дан массив из целых чисел [12, 4, 3, -2, 1, 9, 0], напиши программу которая:
//a) выведет элементы в обратном порядке, через запятую.
//б) выведет элементы умноженные на второй элемент
//
//Нельзя использовать Array.Reverse.
//
//Структуру для всех задач в этом проекте делай на подобии Cakes.cs - внутри Start()


        int[] chisla = {12, 4, 3, -2, 1, 9, 0 };
        int vtoroiElement = chisla[1];
        for(int i = 0; i < chisla.Length; i++)
        {
            int chislo = vtoroiElement * chisla[i];
            Console.Write(chislo + " ");
        }
    }


} 
