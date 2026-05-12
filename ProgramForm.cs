using Smart_Budget.ClassLibrary;

namespace Smart_Budget
{
    public partial class ProgramForm : Form
    {
        private MainMenu _homeScreen;
        private Settings _settingsScreen;
        private FirstTimeInApplication _firstTimeInApplication;
        private GetAnalys _getAnalysis;
        private StartNewWork _startNewWork;


        // Текущий активный контрол
        private UserControl _currentScreen;

        /// <summary>
        /// Конструктор по умолчанию с инициализацией компонентов формы
        /// </summary>
        public ProgramForm()
        {
            InitializeComponent();

            // Создаем экраны
            _homeScreen = new MainMenu();
            _settingsScreen = new Settings();
            _firstTimeInApplication = new FirstTimeInApplication();
            _getAnalysis = new GetAnalys();
            _startNewWork = new StartNewWork();


            // Подписываемся на события кнопок внутри контролов
            //_homeScreen.NavigateToFirstTime += NavigateToStartNewWork;
            _homeScreen.NavigateToFirstTime += NavigateToFirstTime;
            _homeScreen.NavigateToSettings += NavigateToSettings;
            _homeScreen.CloseApplication += CloseApplication;
            _homeScreen.NavigateToStartNewWork += NavigateToStartNewWork;
            
            _settingsScreen.NavigateToHome += NavigateToHome;
            _settingsScreen.NavigateToFirstTime += NavigateToFirstTime;
            _settingsScreen.NavigateToStartNewWork += NavigateToStartNewWork;

            _firstTimeInApplication.NavigateToHome += NavigateToHome;

            _startNewWork.NavigateToHome += NavigateToHome;

            ShowScreen(_homeScreen);
        }

        /// <summary>
        ///Метод для бесшовной смены экрана
        /// </summary>
        /// <param name="newScreen">Принимаемый новый экран</param>
        private void ShowScreen(UserControl newScreen)
        {
            if (_currentScreen == newScreen) 
                return;

            if (_currentScreen != null)
                PanelContainer.Controls.Remove(_currentScreen);

            newScreen.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(newScreen);

            _currentScreen = newScreen;

            if (_currentScreen == _firstTimeInApplication)
                _firstTimeInApplication.StartVideo();        
        }



        //Обработчики навигации
        private void NavigateToHome(object sender, EventArgs e)
        {
            ShowScreen(_homeScreen);
            _firstTimeInApplication.StopVideo(); //Для экрана "О приложении", когда необходимо останавливать видео
        }

        private void NavigateToFirstTime(object sender, EventArgs e)
        {
            ShowScreen(_firstTimeInApplication);
        }

        private void NavigateToSettings(object sender, EventArgs e)
        {
            ShowScreen(_settingsScreen);
        }

        private void NavigateToStartNewWork(object sender, EventArgs e)
        {
            ShowScreen(_startNewWork);
        }

        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
