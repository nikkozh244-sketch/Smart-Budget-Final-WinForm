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
        private UserControl _currentScreen;

        public ProgramForm()
        {
            InitializeComponent();

            _homeScreen = new MainMenu();
            _settingsScreen = new Settings();
            _firstTimeInApplication = new FirstTimeInApplication();
            _getAnalysis = new GetAnalys();
            _startNewWork = new StartNewWork();


            _homeScreen.NavigateToFirstTime += NavigateToFirstTime;
            _homeScreen.NavigateToSettings += NavigateToSettings;
            _homeScreen.CloseApplication += CloseApplication;
            _homeScreen.NavigateToStartNewWork += NavigateToStartNewWork;
            
            _settingsScreen.NavigateToHome += NavigateToHome;
            _settingsScreen.NavigateToFirstTime += NavigateToFirstTime;
            _settingsScreen.NavigateToStartNewWork += NavigateToStartNewWork;

            _firstTimeInApplication.NavigateToHome += NavigateToHome;

            _startNewWork.NavigateToHome += NavigateToHome;

            helpProvider1.HelpNamespace = Path.Combine(Application.StartupPath, "Справочная служба.chm");

            ShowScreen(_homeScreen);
        }

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

        /// <summary>
        ///Ручное переопределение нажима F1 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        { 
            if (keyData == Keys.F1)
            {
                ShowContextHelp();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        ///Метод для показа контекстной справки по экрану 
        /// </summary>
        private void ShowContextHelp()
        {
            //Формируем путь к файлу справки
            string helpPath = Path.Combine(Application.StartupPath, "Справочная служба.chm");

            //Проверяем, существует ли вообще наш справочный файл
            if (!File.Exists(helpPath))
                return;

            //Определяем, какой экран сейчас активен, и переопределяем ключевое слово
            string keyword = GetHelpKeywordForCurrentScreen();

            //Открываем справку
            if (!string.IsNullOrEmpty(keyword))
                Help.ShowHelp(this, helpPath, HelpNavigator.KeywordIndex, keyword);
            else
                Help.ShowHelp(this, helpPath);
        }

        /// <summary>
        ///Переопределение ключевых слов для справки 
        /// </summary>
        /// <returns></returns>
        private string GetHelpKeywordForCurrentScreen() => _currentScreen?.GetType().Name switch
        {
            nameof(MainMenu) => "mainmenu",
            nameof(Settings) => "settings",
            nameof(StartNewWork) => "newwork",
        };

        private void NavigateToHome(object sender, EventArgs e)
        {
            ShowScreen(_homeScreen);
            _firstTimeInApplication.StopVideo();
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

        /// <summary>
        ///Определение метода для закрытия приложения (тут же должна идти выгрузка параметров настроек) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //РЕАЛИЗОВАТЬ МЕТОД ДЛЯ ЗАГРУЗКИ НАСТРОЕК!!!
    }
}
