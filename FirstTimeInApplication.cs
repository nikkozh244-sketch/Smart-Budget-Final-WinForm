using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Smart_Budget
{
    public partial class FirstTimeInApplication : UserControl
    {
        public event EventHandler NavigateToHome;
        public event EventHandler NavigateToStartNewWork;
        public event EventHandler NavigateToSettings;

        public FirstTimeInApplication()
        {
            InitializeComponent();
        }

        public void StartVideo()
        {
            LoadVideo();
        }

        public void StopVideo() 
        { 
            axWindowsMediaPlayer1.Ctlcontrols.stop(); 
        }

        private void LoadVideo()
        {
            string videoPath = Path.Combine(Application.StartupPath, "Обучающее видео, заглушка.mp4");

            if (File.Exists(videoPath))
            {
                axWindowsMediaPlayer1.stretchToFit = true;
                axWindowsMediaPlayer1.URL = videoPath;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.uiMode = "full";
            }
            else
                MessageBox.Show($"Видео не найдено: {videoPath}");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void OpenMenuIcon_Click_1(object sender, EventArgs e)
        {
            NavigateToHome?.Invoke(this, EventArgs.Empty);
            axWindowsMediaPlayer1.Location = new Point(249, 0);
        }
    }
}
