using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Гаргулян Гаргулья Гаргульевич";

            byte age = 19;

            string Email = "gargulyaG@mail.ru";

            float programmingScores = 10.6f;
            float mathScores = 24.2f;
            float physicsScores = 37.2f;

            Console.WriteLine("Ф.И.О: {0} \nВозраст: {1} \nПочта: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}",
                              fullName,
                              age,
                              Email,
                              programmingScores,
                              mathScores,
                              physicsScores);
            Console.ReadKey();

            float valueP = 10.6f; float valueM = 24.2f; float valuePH = 37.2f;
            float valeuA = valueP + valueM + valuePH;
            float valueB = (valueP + valueM + valuePH) / 3;

            Console.WriteLine("Сумма баллов: {0} \nСреднее арифметическое баллов: {1}",
                              valeuA,
                              valueB);
            Console.ReadKey();
        }     
    }
}
