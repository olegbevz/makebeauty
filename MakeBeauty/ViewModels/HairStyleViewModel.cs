// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HairStyleViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the HairStyleViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MakeBeauty.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;

    using MakeBeauty.Data.Entities;

    public class HairStyleViewModel
    {
        private HairStyle _hairStyle;

        /// <summary>
        /// Initializes a new instance of the <see cref="HairStyleViewModel"/> class.
        /// </summary>
        public HairStyleViewModel()
        {
            _hairStyle = new HairStyle(); 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HairStyleViewModel"/> class.
        /// </summary>
        /// <param name="hairStyle">
        /// The hair style.
        /// </param>
        public HairStyleViewModel(HairStyle hairStyle)
            : this(hairStyle, new string[0])
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HairStyleViewModel"/> class.
        /// </summary>
        /// <param name="hairStyle">
        /// The hair style.
        /// </param>
        public HairStyleViewModel(HairStyle hairStyle, IEnumerable<string> images)
        {
            _hairStyle = hairStyle;

            AllImages = images.Select(image => new SelectListItem
                {
                    Text = Path.GetFileName(image),
                    Value = Path.GetFileName(image)
                }).ToArray();
        }

        /// <summary>
        /// Gets or sets Name.
        /// Наименование прически
        /// </summary>
        [DisplayName("Наименование прически")]
        public string Name
        {
            get
            {
                return _hairStyle.name;
            }

            set
            {
                if (value != null)
                {
                    _hairStyle.name = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets Cost.
        /// Стоимость прически
        /// </summary>
        [DisplayName("Стоимость прически")]
        public int Cost
        {
            get
            {
                return _hairStyle.cost ?? 0;
            }

            set
            {
                _hairStyle.cost = value;
            }
        }

        /// <summary>
        /// Gets or sets Time.
        /// Время создания прически
        /// </summary>
        [DisplayName("Время создания прически")]
        public TimeSpan Time
        {
            get
            {
                return _hairStyle.time ?? TimeSpan.Zero;
            }

            set
            {
                _hairStyle.time = value;
            }
        }

        /// <summary>
        /// Gets or sets Description.
        /// Описание прически
        /// </summary>
        [DisplayName("Описание прически")]
        public string Description
        {
            get
            {
                return _hairStyle.description;
            }

            set
            {
                _hairStyle.description = value;
            }
        }

        /// <summary>
        /// Gets or sets SmallImage.
        /// Заглавная картинка для прически
        /// </summary>
        [DisplayName("Заглавная картинка")]
        public string SmallImage 
        {
            get
            {
                return _hairStyle.small_image;
            }

            set
            {
                _hairStyle.small_image = value;
            }
        }

        /// <summary>
        /// Gets or sets BigImages.
        /// </summary>
        [DisplayName("Картинки")]
        public IEnumerable<string> BigImages { get; set; } 

        /// <summary>
        /// Gets HairStyles.
        /// Список потенциальных причесок
        /// </summary>
        public IEnumerable<SelectListItem> AllImages { get; set; }

        /// <summary>
        /// Gets Comments.
        /// Комментарии к прическе
        /// </summary>
        public IEnumerable<Comment> Comments { get; set; }

        /// <summary>
        /// Метод возвращает исходную модель данных
        /// </summary>
        /// <returns>Исходная модель данных</returns>
        public HairStyle GetOriginalSource()
        {
            return _hairStyle;
        }
    }
}