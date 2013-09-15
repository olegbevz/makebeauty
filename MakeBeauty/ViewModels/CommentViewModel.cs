namespace MakeBeauty.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    using MakeBeauty.Data.Entities;

    public class CommentViewModel
    {
        private Comment _comment;

        public CommentViewModel()
        {
            _comment = new Comment { id = -1 };
        }

        public CommentViewModel(Comment comment)
        {
            _comment = comment;
        }

        /// <summary>
        /// Gets or sets Author.
        /// Автор комментария
        /// </summary>
        [Required(ErrorMessage = "Укажите Ваше полное имя")]
        [DisplayName("Автор комментария")]
        public string Author
        {
            get
            {
                return _comment.author;
            }

            set
            {
                _comment.author = value;
            }
        }

        /// <summary>
        /// Gets or sets Message.
        /// Текст комментария
        /// </summary>
        [Required(ErrorMessage = "Введите текст комментария")]
        [DisplayName("Текст сообщения")]
        public string Message
        {
            get
            {
                return _comment.message;
            }

            set
            {
                _comment.message = value;
            }
        }

        /// <summary>
        /// Gets Date.
        /// Дата создания комментария
        /// </summary>
        [DisplayName("Дата добавления")]
        public DateTime Date
        {
            get
            {
                return _comment.date;
            }
        }

        /// <summary>
        /// Метод возвращает оригинальную модель данных для комментария
        /// </summary>
        /// <returns>Модель данных комментария</returns>
        public Comment GetOriginalSource()
        {
            return _comment;
        }
    }
}