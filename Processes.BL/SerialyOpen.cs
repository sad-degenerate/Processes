using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Processes.BL
{
    public class SerialyOpen
    {
        public int NumOfTimes { get; }
        public int Interval { get; }
        public string Path { get; }

        public SerialyOpen(int numOfTimes, int interval, string path = "notepad.exe")
        {
            if(numOfTimes <= 0)
                throw new ArgumentException("Количество запусков программы не может быть меньше нуля.", nameof(numOfTimes));
            if(interval <= 0)
                throw new ArgumentException("Интервал между открытием приложения не может быть меньше нуля.", nameof(interval));
            if(string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path), "Путь к файлу не может быть пустым.");
            
            // TODO: проверка пути (является ли программой).

            Path = path;
            NumOfTimes = numOfTimes;
            Interval = interval;
        }

        public void OpenAndClose()
        {
            var processes = new List<Process>();

            for (var i = 0; i < NumOfTimes; i++)
            {
                processes.Add(Process.Start(Path));
                Thread.Sleep(Interval);
            }

            foreach (var proc in processes)
                proc.Kill();
        }
    }
}