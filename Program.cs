namespace Smart_Budget
{
    internal static class Program
    {

        [STAThread] //Атрибут для корректной работы компонентов
        static void Main()
        {
            ApplicationConfiguration.Initialize(); //Устанавливается базовая конфигурация приложения
            Application.Run(new ProgramForm()); //Форма, которая будет выводится в начале по умолчанию
        }
    }
}