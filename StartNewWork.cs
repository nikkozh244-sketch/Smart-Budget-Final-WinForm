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
    public partial class StartNewWork : UserControl
    {
        // События
        public event EventHandler NavigateToHome;

        // Инициализация экрана
        public StartNewWork()
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
            string originalText = LabelStartNewWork.Text;
            LabelStartNewWork.Text = message;
            await Task.Delay(2000);
            LabelStartNewWork.Text = originalText;
        }

        //Кнопки
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void OpenMenuIcon_Click(object sender, EventArgs e)
        {
            NavigateToHome?.Invoke(this, EventArgs.Empty);
        }

        private void AddData_Click(object sender, EventArgs e)
        {
            ChangeLabel("Новая операция успешно добавлена, муррр!");
        }

        private void ChangeData_Click(object sender, EventArgs e)
        {
            ChangeLabel("Операция была успешно изменена!");
        }

        private void DoneEntering_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке!!!");
        }
    }
}
