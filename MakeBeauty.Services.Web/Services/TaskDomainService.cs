
namespace MakeBeauty.Services.Web
{
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;

    using MakeBeauty.Data.Entities;
    using MakeBeauty.Repositories;
    using MakeBeauty.Services.Web.Models;

    // TODO: Create methods containing your application logic.
    [EnableClientAccess]
    public class TaskDomainService : LinqToEntitiesDomainService<MakeBeautyEntities>, IRepository<TaskProxy>
    {
        private TaskRepository repository;

        public TaskDomainService()
        {
            this.repository = new TaskRepository(ObjectContext);
        }

        public IEnumerable<TaskProxy> GetAll()
        {
            var originalTasks = this.repository.GetAll();

            return originalTasks.Select(task => new TaskProxy(task));
        }

        public TaskProxy Create()
        {
            return new TaskProxy(this.repository.Create());
        }

        [Invoke]
        public TaskProxy GetById(int id)
        {
            return new TaskProxy(this.repository.GetById(id));
        }

        [Insert]
        public void Insert(TaskProxy task)
        {
            this.repository.Insert(task.ToTask());
        }

        [Update]
        public void Update(TaskProxy task)
        {
            this.repository.Update(task.ToTask());
        }

        [Delete]
        public void Delete(TaskProxy task)
        {
            this.repository.Delete(task.Id);
        }

        [Invoke]
        public void Save()
        {
            this.repository.Save();
        }
    }
}


