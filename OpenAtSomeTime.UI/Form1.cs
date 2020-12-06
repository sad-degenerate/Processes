using Processes.BL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpenAtSomeTime.UI
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private string filePath = string.Empty;
        /// <summary>
        /// Время открытия файла.
        /// </summary>
        private DateTime time;

        // Control, который отвечает за выбор времени.
        private DateTimePicker timePicker;

        public Form1()
        {
            InitializeComponent();

            // Настройка, создание и добавление на форму timePicker'а.
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(btnTime.Location.X + 50, btnTime.Location.Y + btnTime.Size.Height + 10);

            Controls.Add(timePicker);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Вызов окна выбора файла.
            using (var openFileDialog = new OpenFileDialog())
            {
                // Выбор только .exe файлов.
                openFileDialog.Filter = "exe Files (.exe)|*.exe";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Добавление выбранного файла в память, отображение пути
                    // выбранного файла в лейбле.
                    filePath = openFileDialog.FileName;
                    lblBrowseStatus.Text = filePath;
                    lblBrowseStatus.ForeColor = Color.Green;
                }
            }
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            // Запись выбранного времени в память, отображение
            // выбранного времени в лейбле.
            time = timePicker.Value;
            lblSetTime.Text = $"{time.Hour}:{time.Minute}:{time.Second}";
            lblSetTime.ForeColor = Color.Green;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на ошибки.
                if (string.IsNullOrWhiteSpace(filePath))
                    throw new ArgumentNullException(nameof(filePath), "File path is empty.");
                if (time == null)
                    throw new ArgumentNullException(nameof(time), "Time is empty");

                // Создание класса, в котором описан функционал программы.
                var atTime = new OpenAtTime(filePath);

                // Вызов метода, который запускает функционал программы.
                atTime.Open(time.Hour, time.Minute, time.Second);
            }
            catch (Exception ex)
            {
                // Вывод ошибки.
                MessageBox.Show(ex.Message);
            }
        }
    }
}