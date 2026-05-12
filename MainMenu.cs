using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Budget
{
    public partial class MainMenu : UserControl
    {
        // Событие для навигации (чтобы главная форма знала)
        public event EventHandler NavigateToSettings;
        public event EventHandler NavigateToFirstTime;
        public event EventHandler CloseApplication;
        public event EventHandler NavigateToStartNewWork;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            // Вызываем событие — главная форма поймет и переключит экран
            NavigateToSettings?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonFirstTime_Click(object sender, EventArgs e)
        {
            // Вызываем событие — главная форма поймет и переключит экран
            NavigateToFirstTime?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            CloseApplication?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonStartNewWork_Click(object sender, EventArgs e)
        {
            // Вызываем событие — главная форма поймет и переключит экран
            NavigateToStartNewWork?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonContinueWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке");
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            // Путь к файлу справки
            string helpFilePath = Application.StartupPath + "\\Справочная служба.chm";

            // Проверяем, существует ли файл
            if (System.IO.File.Exists(helpFilePath))
            {
                System.Windows.Forms.Help.ShowHelp(null, helpFilePath);
            }
            else
            {
                MessageBox.Show("Файл справки не найден: " + helpFilePath);
            }
        }
    }
}
