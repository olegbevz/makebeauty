// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TaskViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the TaskViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MakeBeauty.ViewModels
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    using MakeBeauty.Data.Entities;

    /// <summary>
    /// Модель представления для заказа
    /// </summary>
    public class TaskViewModel
    {
        /// <summary>
        /// Модель данных для заказа
        /// </summary>
        private Task _task;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskViewModel"/> class.
        /// </summary>
        public TaskViewModel()
        {
            _task = new Task();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskViewModel"/> class.
        /// </summary>
        /// <param name="task">
        /// The task.
        /// </param>
        /// <param name="hairStyles">
        /// The hair Styles.
        /// </param>
        public TaskViewModel(Task task, IEnumerable<HairStyle> hairStyles)
        {
            _task = task;

            HairStyles = hairStyles.Select(style => new SelectListItem
                {
                    Value = style.id + ";" + style.small_image, 
                    Text = style.name
                }).ToArray();
        }

        /// <summary>
        /// Gets or sets Id.
        /// Идентификатор клиента
        /// </summary>
        [Key()]
        public int Id
        {
            get
            {
                return _task.id;
            }
            set
            {
                _task.id = value;
            }
        }

        /// <summary>
        /// Gets or sets Client.
        /// Файмилия, имя, отчестсво клиента
        /// </summary>
        [DisplayName("Укажите Ваше полное имя:")]
        [Required(ErrorMessage = "Укажите Ваше полное имя")]
        [StringLength(50, ErrorMessage = "Слишком длинное имя. Таких не бывает.")]
        public string Client
        {
            get
            {
                return _task.client ?? string.Empty;
            }

            set
            {
                if (value != null)
                {
                    _task.client = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets Phone.
        /// Номер телефона клиента
        /// </summary>
        [DisplayName("Укажите Ваш номер телефона:")]
        [Required(ErrorMessage = "Укажите Ваш номер телефона. Иначе мы не сможем связаться с Вами.")]
        [StringLength(50, ErrorMessage = "Слишком длинный номер телефона. Таких не бывает.")]
        public string Phone
        {
            get
            {
                return _task.phone ?? string.Empty;
            }
            set
            {
                if (value != null)
                {
                    _task.phone = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets Description.
        /// Дополнительная информация
        /// </summary>
        [DisplayName("Ваши дополнительные пожелания:")]
        public string Description
        {
            get
            {
                return _task.description ?? string.Empty;
            }
            set
            {
                _task.description = value;
            }
        }
        
        /// <summary>
        /// Gets or sets Date
        /// Предположительное время выполнения заказа
        /// </summary>
        [DisplayName("Укажите дату создания прически:")]
        public DateTime Date
        {
            get
            {
                return _task.date ?? DateTime.Now;
            }
            set
            {
                _task.date = value;
            }
        }

        /// <summary>
        /// Gets or sets HairStyleId.
        /// Идентификатор типа причеки
        /// </summary>
        [DisplayName("Выберите прическу:")]
        public string HairStyleId
        {
            get
            {
                return (_task.hairstyle_id ?? 0).ToString();
            }

            set
            {
                _task.hairstyle_id = int.Parse(value);
            }
        }

        /// <summary>
        /// Gets HairStyleImage.
        /// Заглавная картинка заказываемой прически
        /// </summary>
        public string HairStyleImage
        {
            get
            {
                if (_task.HairStyle != null)
                {
                    return _task.HairStyle.small_image;
                }

                return null;
            }
        }

        /// <summary>
        /// Gets HairStyles.
        /// Список потенциальных причесок
        /// </summary>
        public IEnumerable<SelectListItem> HairStyles { get; private set; } 

        public string SelectedHairStyleItem
        {
            get 
            { 
                if (_task.HairStyle != null)
                {
                    return _task.HairStyle.id + ";" + _task.HairStyle.small_image;
                }

                return string.Empty;
            }

            set
            {
                if (HairStyles != null &&
                    HairStyles.Any(item => item.Value == value))
                {
                    var parts = value.Split(';');

                    _task.hairstyle_id = int.Parse(parts[0]);
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <returns>
        /// </returns>
        public Task GetOriginalSource()
        {
            return _task;
        }
    }
}