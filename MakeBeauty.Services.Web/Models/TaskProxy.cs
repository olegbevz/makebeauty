namespace MakeBeauty.Services.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MakeBeauty.Data.Entities;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public class TaskProxy
    {
        public TaskProxy()
        {
            this.Id = 0;

            this.Client = string.Empty;

            this.Phone = string.Empty;

            this.Description = string.Empty;

            this.Date = DateTime.Now;

            this.HairStyleId = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskProxy"/> class.
        /// </summary>
        /// <param name="task">
        /// The task.
        /// </param>
        public TaskProxy(Task task)
        {
            this.Id = task.id;

            this.Client = task.client;

            this.Phone = task.phone;

            this.Description = task.description;

            this.Date = task.date ?? DateTime.Now;

            this.HairStyleId = task.hairstyle_id ?? 0;
        }

        #region Properties

        [Key]
        public int Id { get; set; }

        public string Client { get; set; }

        public string Phone { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public int HairStyleId { get; set; }

        #endregion

        public Task ToTask()
        {
            var task = new Task
                {
                    id = this.Id,
                    client = this.Client,
                    phone = this.Phone,
                    description = this.Description,
                    date = this.Date,
                    hairstyle_id = this.HairStyleId
                };

            return task;
        }
    }
}