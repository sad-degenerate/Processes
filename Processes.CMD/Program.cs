using System;
using System.Threading;
using Processes.BL;

namespace Processes.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Открытие нескольких программ через какой-то период времени, а потом их закрытие.");
            Console.WriteLine("2 - Вывод информации о всех процессах.");
            Console.WriteLine("3 - Запуск программы в определённое время.");
            Console.Write("\nВаш ответ: ");

            switch (Console.ReadLine())
            {
                case "1":
                    PeriodOpen();
                    break;

                case "2":
                    ShowProc();
                    break;

                case "3":
                    OpenAtSomeTime();
                    break;

                default:
                    Console.WriteLine("Некорректный ввод данных.");
                    break;
            }
        }

        static void ShowProc()
        {
            Console.Clear();

            Console.Write("Введите интервал между обновлениями списка (в миллисекундах): ");

            ShowProcesses.Show(int.Parse(Console.ReadLine()));

            Console.Clear();
        }

        static void OpenAtSomeTime()
        {
            Console.Clear();

            Console.Write("Введите путь к процессу (программе), который вы хотите открыть (например, \"notepad.exe\"): ");
            var path = Console.ReadLine();

            Console.Write("Введите время запуска (формат - 16:00:00): ");
            DateTime time;
            // TODO: Формат даты.
            if(!DateTime.TryParse(Console.ReadLine(), out time))
            {
                Console.WriteLine("Некорректная дата.");
                return;
            }

            var atTime = new OpenAtTime(path);

            atTime.Open(time.Hour, time.Minute, time.Second);

            while (atTime.LastOpen != DateTime.Today)
                Thread.Sleep(500);
        }

        static void PeriodOpen()
        {
            Console.Clear();

            Console.Write("Введите путь к процессу (программе), который вы хотите запустить (например, \"notepad.exe\"): ");
            var path = Console.ReadLine();

            Console.Write("Введите количество раз, которое процесс будет выполнятся: ");
            int numOfTimes;
            if (!int.TryParse(Console.ReadLine(), out numOfTimes))
            {
                Console.WriteLine("Введённое вами значение - не int.");
                return;
            }

            Console.Write("Введите интервал между каждым открытием процесса (в миллисекундах): ");
            int interval;
            if (!int.TryParse(Console.ReadLine(), out interval))
            {
                Console.WriteLine("Введённое вами значение - не int.");
                return;
            }

            var serOpen = new SerialyOpen(numOfTimes, interval, path);

            serOpen.OpenAndClose();
        }
    }
}