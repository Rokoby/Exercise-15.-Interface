using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Реализация арифметической прогрессии:");
            ArithProgression arith = new ArithProgression();
            Console.Write("Введите начальное значение:");
            arith.SetStart(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Введите шаг:");
            arith.SetStep(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());

            Console.WriteLine("Сброс");
            arith.Reset();
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());

            Console.WriteLine("Реализация геометрической прогрессии:");
            GeomProgression geom = new GeomProgression();
            Console.Write("Введите начальное значение:");
            geom.SetStart(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Введите шаг:");
            geom.SetStep(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());

            Console.WriteLine("Сброс");
            geom.Reset();
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.ReadKey();
        }
    }
}