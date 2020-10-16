using System;
using System.Diagnostics;
using System.Threading;

namespace Processes.BL
{
    public class OpenAtTime
    {
        public DateTime LastOpen { get; private set; }
        public string Path { get; }
        public Timer Timer { get; private set; }

        public OpenAtTime(string path = "notepad.exe")
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path), "Путь к файлу не может быть пустым.");

            Path = path;
        }

        public void Open(int hour, int min, int sec)
        {
            SetUpTimer(new TimeSpan(hour, min, sec));
        }

        private void SetUpTimer(TimeSpan time)
        {
            var currentTime = DateTime.Now;
            var timeToGo = time - currentTime.TimeOfDay;

            if (timeToGo < TimeSpan.Zero)
                return;

            Timer = new Timer(x =>
            {
                OpenProgram();
            }, null, timeToGo, Timeout.InfiniteTimeSpan);
        }

        private void OpenProgram()
        {
            Process.Start(Path);
            LastOpen = DateTime.Today;
        }
    }
}
