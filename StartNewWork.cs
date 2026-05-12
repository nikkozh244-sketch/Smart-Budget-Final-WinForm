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
        public event EventHandler NavigateToHome;

        public StartNewWork()
        {
            InitializeComponent();
        }

        private async Task ChangeLabel(string message)
        {
            string originalText = LabelStartNewWork.Text;
            LabelStartNewWork.Text = message;
            await Task.Delay(2000);
            LabelStartNewWork.Text = originalText;
        }

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
    }
}
