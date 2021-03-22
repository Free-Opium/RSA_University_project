using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_University_project_Vysochina
{    public class RandomGenerator
    {
        //Переменные

        //Публичные
        //Текущее значение рандома
        static public long currentRandomValue;
        //Текущее значение сида
        static public long currentSeedValue;

        //Нижний предел
        static public long rangeMin;
        //Верхний предел
        static public long rangeMax;

        //Пределы генерации по умолчанию
        static public readonly long rangeMinDefault = 0;
        static public readonly long rangeMaxDefault = Int32.MaxValue;



        //Методы

        //Публичные
        //Генерация сида из таймстампа
        static public long GenerateSeedFromTimestamp()
        {
            var seed = Math.Abs((DateTime.Now.Minute +
                                             DateTime.Now.Second *100 
                                            ^ DateTime.Now.Day 
                                            * DateTime.Now.Millisecond * 100000) 
                                            / DateTime.Now.Hour * 100000000);
            currentSeedValue = seed;

            return seed;
        }

        //Генерация рандомного значения
        static public long GenerateNext(long seed, long rangeMin, long rangeMax)
        {
            //Вычленение центральных 16 разрядов
            long center = seed >> 8; 
            center &= 0b1111111111111111;

            //Вычисление по методу серединных квадратов и отсечение до стандартного диапазона
            var generatedNum = Math.Abs(center * center) % rangeMaxDefault; 

            currentSeedValue = generatedNum; //Присвоение новго сида

            //Приведение к желаемому диапазону
            currentRandomValue = CastToRange(generatedNum, rangeMin, rangeMax); 

            return currentRandomValue;
        }

        //Приватные
        //Преобразование пределов
        static private long CastToRange(long value, long rangeMinNew, long rangeMaxNew)
        {
            return ((value - rangeMinDefault) * (rangeMaxNew - rangeMinNew) 
                    / (rangeMaxDefault - rangeMinDefault)) 
                    + rangeMinNew;
        }

        //Конструкторы

        //Конструктор без параметров - создаем сид сами, пределов нет
        public RandomGenerator()
        {
            currentSeedValue = GenerateSeedFromTimestamp();
            currentRandomValue = currentSeedValue;
            rangeMin = rangeMinDefault;
            rangeMax = rangeMaxDefault;
        }
        //Конструктор с сидом - берем сид, пределов нет
        public RandomGenerator(long seed)
        {
            currentSeedValue = seed;
            currentRandomValue = currentSeedValue;
            rangeMin = rangeMinDefault;
            rangeMax = rangeMaxDefault;
        }

        //Полный конструктор - берем сид, берем пределы
        public RandomGenerator(long seed, long rangeMin, long rangeMax)
        {
            currentSeedValue = seed;
            currentRandomValue = currentSeedValue;
            RandomGenerator.rangeMin = rangeMin;
            RandomGenerator.rangeMax = rangeMax;
        }


    }
}
