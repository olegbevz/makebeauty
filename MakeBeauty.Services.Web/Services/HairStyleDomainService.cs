
namespace MakeBeauty.Services.Web
{
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;

    using MakeBeauty.Data.Entities;
    using MakeBeauty.Data.Repositories;
    using MakeBeauty.Repositories;
    using MakeBeauty.Services.Web.Models;

    // TODO: Create methods containing your application logic.
    [EnableClientAccess]
    public class HairStyleDomainService : LinqToEntitiesDomainService<MakeBeautyEntities>, IRepository<HairStyleProxy>
    {
        private HairStyleRepository repository;

        public HairStyleDomainService()
        {
            repository = new HairStyleRepository(ObjectContext);
        }

        /// <summary>
        /// Получение всех экземпляров сущности
        /// </summary>
        /// <returns>
        /// Список экземпляров сущности
        /// </returns>
        public IEnumerable<HairStyleProxy> GetAll()
        {
            return repository.GetAll().Select(entity => new HairStyleProxy(entity));
        }

        /// <summary>
        /// Создание нового экземпляра сущности
        /// </summary>
        /// <returns>
        /// Новый экземпляр сущности
        /// </returns>
        public HairStyleProxy Create()
        {
            return new HairStyleProxy(repository.Create());
        }

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
        [Invoke]
        public HairStyleProxy GetById(int id)
        {
            return new HairStyleProxy(repository.GetById(id));
        }

        /// <summary>
        /// Добавление нового экземпляра
        /// </summary>
        /// <param name="entity">
        /// Добавляемый экземпляр
        /// </param>
        [Insert]
        public void Insert(HairStyleProxy entity)
        {
            repository.Insert(entity.ToHairStyle());
        }

        /// <summary>
        /// Обновление данных экземпляра
        /// </summary>
        /// <param name="currentEntity">
        /// Обновляемый экземпляр
        /// </param>
        [Update]
        public void Update(HairStyleProxy currentEntity)
        {
            this.repository.Update(currentEntity.ToHairStyle());
        }

        /// <summary>
        /// Удаление экземпляра
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        [Delete]
        public void Delete(HairStyleProxy entity)
        {
            this.repository.Delete(entity.Id);
        }

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        [Invoke]
        public void Save()
        {
            this.repository.Save();
        }
    }
}


