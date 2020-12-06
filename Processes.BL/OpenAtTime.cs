using System;
using System.Diagnostics;
using System.Threading;

namespace Processes.BL
{
    public class OpenAtTime
    {
        /// <summary>
        /// Время, когда программа запускалась в последний раз.
        /// </summary>
        public DateTime LastOpen { get; private set; }
        /// <summary>
        /// Путь к запускаемой программе.
        /// </summary>
        public string Path { get; }

        // Control, который отвечает за время запуска программы.
        public Timer Timer { get; private set; }

        public OpenAtTime(string path = "notepad.exe")
        {
            Path = path;
        }

        public void Open(int hour, int min, int sec)
        {
            SetUpTimer(new TimeSpan(hour, min, sec));
        }

        private void SetUpTimer(TimeSpan time)
        {
            // Текущее время.
            var currentTime = DateTime.Now;
            // Время, которое будет действовать таймер.
            var timeToGo = time - currentTime.TimeOfDay;

            // Проверка на отрицательное время.
            if (timeToGo < TimeSpan.Zero)
                return;

            // Создание таймера, по истечению которого будет открыта программа.
            Timer = new Timer(x =>
            {
                OpenProgram();
            }, null, timeToGo, Timeout.InfiniteTimeSpan);
        }

        private void OpenProgram()
        {
            // Открытие программы.
            Process.Start(Path);
            LastOpen = DateTime.Today;
        }
    }
}
