using System.Collections.Generic;

namespace CarRental.Application.Interfaces
{
    interface IOrderService
    {
        /// <summary>
        /// Возвращает название наиболее часто арендуемого автомобиля.
        /// </summary>
        /// <returns>Коллекция названий автомобилей. Несколько элементов возвращается в случае,
        /// если несколько различных автомобилей были арендованы одинаковое (наибольшее) количество раз.
        /// </returns>
        IEnumerable<string> GetMostPopularCar();
    }
}
