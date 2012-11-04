// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TaskRepository.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the TaskRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MakeBeauty.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Objects;
    using System.Linq;

    using MakeBeauty.Data;
    using MakeBeauty.Data.Entities;

    public class TaskRepository : IRepository<Task>
    {
        private MakeBeautyEntities ObjectContext { get; set; }

        public TaskRepository() : this (new MakeBeautyEntities())
        {
        }

        public TaskRepository(MakeBeautyEntities objectContext)
        {
            ObjectContext = objectContext;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Tasks' query.
        public IEnumerable<Task> GetAll()
        {
            return this.ObjectContext.Tasks;
        }

        public Task Create()
        {
            var task = new Task();

            task.client = string.Empty;

            task.id = 0;

            task.phone = string.Empty;

            task.description = string.Empty;

            task.date = DateTime.Now;

            if (ObjectContext.HairStyles.Any())
            {
                task.hairstyle_id = ObjectContext.HairStyles.First().id;
            }

            return task;
        }

        public Task GetById(int id)
        {
            return ObjectContext.Tasks.FirstOrDefault(task => task.id == id);
        }

        public void Insert(Task task)
        {
            task.id = KeyGenerator.Generate(ObjectContext.Tasks.Select(t => t.id));

            if (task.EntityState != EntityState.Detached)
            {
                ObjectContext.ObjectStateManager.ChangeObjectState(task, EntityState.Added);
            }
            else
            {
                ObjectContext.AddToTasks(task);
            }

            ObjectContext.SaveChanges(SaveOptions.AcceptAllChangesAfterSave);
        }

        /// <summary>
        /// Обновление данных экземпляра
        /// </summary>
        /// <param name="currentEntity">
        /// Обновляемый экземпляр
        /// </param>
        public void Update(Task currentEntity)
        {
            var task = GetById(currentEntity.id);

            task.client = currentEntity.client;
            task.date = currentEntity.date;
            task.phone = currentEntity.phone;
            task.description = currentEntity.description;
            task.hairstyle_id = currentEntity.hairstyle_id;

            ObjectContext.Tasks.ApplyCurrentValues(task);
        }

        public void Delete(int id)
        {
            var tasks = this.GetAll();

            Delete(tasks.FirstOrDefault(task => task.id == id));
        }

        public void Delete(Task task)
        {
            if (task.EntityState != EntityState.Detached)
            {
                ObjectContext.ObjectStateManager.ChangeObjectState(task, EntityState.Deleted);
            }
            else
            {
                ObjectContext.Tasks.Attach(task);
                ObjectContext.Tasks.DeleteObject(task);
            }
        }

        public void Save()
        {
            ObjectContext.SaveChanges();
        }
    }
}