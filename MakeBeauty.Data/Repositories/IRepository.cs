namespace MakeBeauty.Repositories
{
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        /// <summary>
        /// Получение всех экземпляров сущности
        /// </summary>
        /// <returns>
        /// Список экземпляров сущности
        /// </returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Получение экземпляра сущности 
        /// по идентификатору
        /// </summary>
        /// <param name="id">
        /// Идентификатор экземпляра сущности
        /// </param>
        /// <returns>
        /// Экземпляр сущности
        /// </returns>
        T GetById(int id);

        /// <summary>
        /// Создание нового экземпляра сущности
        /// </summary>
        /// <returns>
        /// Новый экземпляр сущности
        /// </returns>
        T Create();

        /// <summary>
        /// Добавление нового экземпляра
        /// </summary>
        /// <param name="entity">
        /// Добавляемый экземпляр
        /// </param>
        void Insert(T entity);

        /// <summary>
        /// Обновление данных экземпляра
        /// </summary>
        /// <param name="currentEntity">
        /// Обновляемый экземпляр
        /// </param>
        void Update(T currentEntity);

        /// <summary>
        /// Удаление экземпляра
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void Delete(T entity);

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        void Save();
    }
}