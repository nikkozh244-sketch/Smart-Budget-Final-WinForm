using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Budget.ClassLibrary
{
    internal class AnalyticsService : BudgetService
    {
        /// <summary>
        /// Метод для определения итоговых трат
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public float TotalIncome()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод для определения итоговых доходов
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public float TotalConsumption()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод для поиска самой популярной категории трат
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string FindMostPopularConsumptionCategory()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод для поиска самой популярной категории доходов (под вопросом необходимости)
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string FindMostPopularIncomeCategory()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод для поиска текущего баланса
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public float FindBalance()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод для вывода совета по итогам трат
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string ShowAdviceByConsumption()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод для вывода совета по категории
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string ShowAdviceByCategories()
        {
            throw new NotImplementedException();
        }
    }
}
