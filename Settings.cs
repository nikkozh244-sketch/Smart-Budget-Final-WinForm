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
    public partial class Settings : UserControl
    {
        // События экрана (СПРОСИТЬ ПРО МЕНЮШКУ!!!!!!!!!!)
        public event EventHandler NavigateToHome;
        public event EventHandler NavigateToFirstTime;
        public event EventHandler NavigateToStartNewWork;
        public event EventHandler NavigateToSettings;

        /// <summary>
        ///Инициализация экрана 
        /// </summary>
        public Settings()
        {
            InitializeComponent();
        }

        /// <summary>
        ///Метод для временного изменения текста сообщения пользователю (ИЗМЕНИТЬ, ТАК КАК ЕСТЬ ШАНС ПОЛНОСТЬЮ ИЗБАВИТЬСЯ ОТ ОСНОВНОГО ЗАГОЛОВКА!!!) 
        /// </summary>
        /// <param name="message">Выводимое сообщение</param>
        /// <returns></returns>
        private async Task ChangeLabel(string message)
        {
            string originalText = LabelSettings.Text;
            LabelSettings.Text = message;
            await Task.Delay(2000);
            LabelSettings.Text = originalText;
        }

        /// <summary>
        ///Метод для показа меню (СПРОСИТЬ!!!) 
        /// </summary>
        private void ShowMenu()
        {
            pnlMenu.BackColor = Color.White;

            pnlMenu.Visible = true;
        }

        /// <summary>
        ///Метод, чтобы спрятать меню (ВНОВЬ СПРОСИТЬ!!!) 
        /// </summary>
        private void HideMenu()
        {
            pnlMenu.Visible = false;
        }

        //Кнопки
        private void OpenMenuIcon_Click(object sender, EventArgs e)
        {
            NavigateToHome?.Invoke(this, EventArgs.Empty);
            LabelSettings.Text = "Добро пожаловать в меню настроек, мяу! Здесь вы можете настроить приложение специально под себя";
        }

        private void ButtonApplySettings_Click(object sender, EventArgs e)
        {
            ChangeLabel("Настройки успешно применены, мяу!");
        }

        private void ButtonResetSettings_Click(object sender, EventArgs e)
        {
            ChangeLabel("Мур! Настройки сброшены до изначальных!");
        }

        private void ButtonFirstTime_Click(object sender, EventArgs e)
        {
            NavigateToFirstTime?.Invoke(this, EventArgs.Empty);
            HideMenu();
        }

        private void ButtonStartNewWork_Click(object sender, EventArgs e)
        {
            NavigateToStartNewWork?.Invoke(this, EventArgs.Empty);
            HideMenu();
        }

        private void pnlOverlay_Click(object sender, PaintEventArgs e)
        {
            NavigateToSettings?.Invoke(this, EventArgs.Empty);
            HideMenu();
        }

        private void ButtonReturnToHome_Click(object sender, EventArgs e)
        {
            NavigateToHome?.Invoke(this, EventArgs.Empty);
            LabelSettings.Text = "Добро пожаловать в меню настроек, мяу! Здесь вы можете настроить приложение специально под себя";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
