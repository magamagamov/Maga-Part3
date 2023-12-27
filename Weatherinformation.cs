﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maga_Part3
{ 
    internal class Weatherinformation
    {


       // Задача: Анализ данных о погоде
       //
       // Напишите программу на C#, которая анализирует ежедневные данные о погоде за месяц.
       //     Данные о погоде представлены в виде массива,
       //     где каждый элемент содержит информацию о температуре (в градусах Цельсия)
       //     и количестве осадков (в миллиметрах) за день.
       //
       // Входные данные:
       //
       // Массив int[] temperatures с температурами за каждый день месяца.
       // Массив int[] precipitation с количеством осадков за каждый день месяца.
       // 
       // Требования к программе:
       // 
       // Рассчитать среднюю месячную температуру.
       // Определить самый холодный и самый теплый дни в месяце.
       // Посчитать общее количество осадков за месяц.
       // Найти количество дней с осадками выше среднего.
       // Вывести индексы дней,
       // когда была заморозка (температура ниже 0 градусов Цельсия) и осадки были выше,
       //             чем в предыдущий день.
       // 
       // Выходные данные:
       // 
       // Вывести на экран среднюю месячную температуру.
       // Вывести индексы самого холодного и самого теплого дня.
       // Вывести общее количество осадков за месяц.
       // Вывести количество дней с осадками выше среднего.
       // Вывести индексы дней с заморозками и увеличением осадков по сравнению с предыдущим дне

            public static void Start()
            {
                int[] temperatures = new int[30];
                int[] precipitationS = new int[30];

                Random numberTemp = new Random();
                for (int i = 0; i < temperatures.Length; i++)
                {
                    temperatures[i] = numberTemp.Next(-15, 45);
                }
                Random numberPrecip = new Random();
                Console.WriteLine();
                for (int i = 0; i < precipitationS.Length; i++)
                {
                    precipitationS[i] = numberPrecip.Next(0, 10);
                }
                Console.WriteLine();

                ShowAverageTemperature(temperatures);
                ShowHotAndColdDayIndeces(temperatures);

                //Console.WriteLine("Среднее количество осадков за месяц");
                int totalPrecipitations = ShowAndReturnTotalPrecipitation(precipitationS);
                int averagePrecipitation = totalPrecipitations / precipitationS.Length;
                Console.WriteLine(averagePrecipitation);

                Console.WriteLine("Количество дней с осадками выше среднего");
                int[] daysWithUpAveragePrecipitation = { };

                int x = 0;
                foreach (int precipitation in precipitationS)
                {
                    if (precipitation > averagePrecipitation)
                    {
                        x++;
                        Array.Resize(ref daysWithUpAveragePrecipitation, x);
                        daysWithUpAveragePrecipitation[x - 1] = precipitation;
                    }
                }
                Console.WriteLine(daysWithUpAveragePrecipitation.Length);

                Console.WriteLine("Индексы дней с заморозками и увеличением осадков по сравнению с предыдущим днем: ");

                for (int i = 1; i < temperatures.Length; i++)
                {
                    if (temperatures[i] < 0 && precipitationS[i] > precipitationS[i - 1])
                    {
                        int frostsAndHeavyPrecipitation = i;
                        Console.Write($"{frostsAndHeavyPrecipitation}, ");
                    }
                }
            }
            private static int ShowAndReturnTotalPrecipitation(int[] precipitations)
            {
                Console.WriteLine("Расчет общего количества осадков за месяц");
                int allPrecipitations = 0;
                for (int i = 0; i < precipitations.Length; i++)
                {
                    allPrecipitations += precipitations[i];
                }
                Console.WriteLine(allPrecipitations);

                return allPrecipitations;
            }
            private static void ShowHotAndColdDayIndeces(int[] temperatures)
            {
                int maxValue = temperatures.Max();
                int maxIndex = temperatures.ToList().IndexOf(maxValue);
                Console.WriteLine("Индекс самого жаркого дня в месяце: ");
                Console.WriteLine(maxIndex);

                int minValue = temperatures.Min();
                int minIndex = temperatures.ToList().IndexOf(minValue);
                Console.WriteLine("Индекс самого холодного дня в месяце: ");
                Console.WriteLine(minIndex);
            }
            private static void ShowAverageTemperature(int[] temperatures)
            {
                Console.WriteLine("Расчет средней месячной температуры");
                int totalTemperature = 0;
                for (int i = 0; i < temperatures.Length; i++)
                {
                    totalTemperature += temperatures[i];
                }
                int averageTemperature = totalTemperature / temperatures.Length;
                Console.WriteLine(averageTemperature);
            }
        }       
            
            
            
            
    }
