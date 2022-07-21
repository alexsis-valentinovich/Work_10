using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.   Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. Реализовать класс,
//в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных. Класс должен
//содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы. Создать объект на
//основе разработанного класса. Осуществить использование объекта в программе.
namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение угла");
            Console.WriteLine("Градусы");
            double gradus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Минуты");
            double minute = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Секунды");
            double second = Convert.ToDouble(Console.ReadLine());
            Ugoll ugoll = new Ugoll(gradus, minute, second);
            double gradusRadian = ugoll.ToRadians();
            Console.WriteLine("Значение угла в радианах = {0:0.0000}", gradusRadian);
            Console.ReadLine();
        }

    }
}
