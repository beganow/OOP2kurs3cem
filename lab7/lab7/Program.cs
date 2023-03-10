using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Fifth();
            
            Third();
            Fourth();
            Second();
            
        }

        public static void Fifth()
        {
            /*.TODO Добавьте   методы сохранения объектов обобщённого типа  CollectionType<T>в файли чтения из него( на выбор: текстовый | xml | json).*/

            var stringList = new List<string>();


            stringList.Add("255");
            stringList.Add("120");
            stringList.Add("1000");
            stringList.Show();
            stringList.WriteToFile<string>();
            stringList.ReadFromFile<string>();
        }

        public static void Fourth()
        {
            /*4.Определить пользовательский класс, который будет использоваться в качестве  параметра обобщения.  Для  пользовательского  типа  взять  класс  из лабораторной No5 «Наследование». */

            var BenchList = new List<Bench>();
            BenchList.Add(new Bench());
            BenchList.Add(new Bench("A", 300));
            BenchList.Add(new Bench("B", 1000));
            BenchList.Show();
        }

        public static void Third()
        {
            /*Проверьте использование обобщения для стандартных типов данных (в качестве стандартных типов использовать целые, вещественные и т.д.).*/

            var stringList = new List<string>();
            var intList = new List<int>();
            var doubleList = new List<double>();


            stringList.Add("A");
            stringList.Add("B");
            stringList.Add("C");
            stringList.Delete("B");
            stringList.Show();


            intList.Add(12);
            intList.Add(13);
            intList.Add(14);
            intList.Delete(14);
            intList.Show();


            doubleList.Add(1.2);
            doubleList.Add(2.2);
            doubleList.Add(3.2);
            doubleList.Delete(3.2);
            doubleList.Show();

        }

        public static void Second()
        {
            /*2.Возьмите  за  основу  лабораторную  No  3 «Перегрузка  операций»и сделайте  из  нееобобщенный тип  (класс)CollectionType<T>,  в  который вложите обобщённую коллекцию.
             Наследуйте в обобщенном классе интерфейс из  п.1. Реализуйтенеобходимые  методы(добавления,  удаления,  поиска  по предикату).
             Добавьте обработку исключений c finally.Наложите какое-либо ограничениена обобщение*/

            var list = new List<int>();
            try
            {
                list.Add(12);
                list.Add(13);
                list.Add(14);
                list.Add(19);
                list.Add(22);
                list.Show();
                list.Delete(13);
                list.Show();
                list.Delete(12);
                list.Show();
                list.Delete(14);
                list.Show();
                list.Delete(14);
            }
            catch (InvalidOperationException e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }Console.ReadKey(true);
        }
        
    }

    internal class T
    {
    }
}
