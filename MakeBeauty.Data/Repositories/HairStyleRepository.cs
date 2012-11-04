// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HairStyleRepository.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the HairStyleRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MakeBeauty.Data.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Objects;
    using System.Linq;

    using MakeBeauty.Data.Entities;
    using MakeBeauty.Repositories;

    public class HairStyleRepository : IRepository<HairStyle>
    {
        private MakeBeautyEntities ObjectContext { get; set; }

        public HairStyleRepository(MakeBeautyEntities entities)
        {
            ObjectContext = entities;
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
        public HairStyle GetById(int id)
        {
            return ObjectContext.HairStyles.FirstOrDefault(hairStyle => hairStyle.id == id);
        }
        
        public void Delete(int id)
        {
            var removingHairStyle = this.GetById(id);

            Delete(removingHairStyle);
        }

        public IEnumerable<Comment> GetHairStyleComments(int id)
        {
            return from comment in ObjectContext.Comments
                   where (from pair in ObjectContext.HairStyle_Comment
                              where pair.hairstyle_id == id
                              select pair.comment_id).Contains(comment.id)
                       select comment;
        }

        public HairStyle GetHairStyleByCommentId(int id)
        {
            return
                ObjectContext.HairStyles.FirstOrDefault(
                    hairStyle =>
                    hairStyle.id
                    == ObjectContext.HairStyle_Comment.FirstOrDefault(pair => pair.comment_id == id).hairstyle_id);
        }

        public void RegisterHairStyleComment(int id, Comment comment)
        {
            var pair = new HairStyle_Comment { hairstyle_id = id, comment_id = comment.id };

            if (ObjectContext.HairStyle_Comment.Any())
            {
                pair.id = ObjectContext.HairStyle_Comment.Max(p => p.id) + 1;
            }

            ObjectContext.HairStyle_Comment.AddObject(pair);

            ObjectContext.SaveChanges();
        }

        public IEnumerable<string> GetHairStyleImages(int id)
        {
            return from image in ObjectContext.HairStyle_BigImage 
                   where image.hairstyle_id == id
                   select image.big_image;
        }

        /// <summary>
        /// Получение всех экземпляров сущности
        /// </summary>
        /// <returns>
        /// Список экземпляров сущности
        /// </returns>
        public IEnumerable<HairStyle> GetAll()
        {
            return ObjectContext.HairStyles;
        }

        /// <summary>
        /// Создание нового экземпляра сущности
        /// </summary>
        /// <returns>
        /// Новый экземпляр сущности
        /// </returns>
        public HairStyle Create()
        {
            return ObjectContext.HairStyles.CreateObject();
        }

        /// <summary>
        /// Добавление нового экземпляра
        /// </summary>
        /// <param name="entity">
        /// Добавляемый экземпляр
        /// </param>
        public void Insert(HairStyle entity)
        {
            entity.id = KeyGenerator.Generate(ObjectContext.HairStyles.Select(t => t.id));

            if (entity.EntityState != EntityState.Detached)
            {
                ObjectContext.ObjectStateManager.ChangeObjectState(entity, EntityState.Added);
            }
            else
            {
                ObjectContext.AddToHairStyles(entity);
            }

            ObjectContext.SaveChanges(SaveOptions.AcceptAllChangesAfterSave);
        }

        /// <summary>
        /// Обновление данных экземпляра
        /// </summary>
        /// <param name="currentEntity">
        /// Обновляемый экземпляр
        /// </param>
        public void Update(HairStyle currentEntity)
        {
            var originalHairStyle = GetById(currentEntity.id);

            if (originalHairStyle != null)
            {
                originalHairStyle.name = currentEntity.name;
                originalHairStyle.description = currentEntity.description;
                originalHairStyle.small_image = currentEntity.small_image;
                originalHairStyle.time = currentEntity.time;
                originalHairStyle.cost = currentEntity.cost;

                ObjectContext.HairStyles.ApplyCurrentValues(originalHairStyle);
            }
        }

        /// <summary>
        /// Удаление экземпляра
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        public void Delete(HairStyle entity)
        {
            if (entity.EntityState != EntityState.Detached)
            {
                ObjectContext.ObjectStateManager.ChangeObjectState(entity, EntityState.Deleted);
            }
            else
            {
                ObjectContext.HairStyles.Attach(entity);
                ObjectContext.HairStyles.DeleteObject(entity);
            }
        }

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        public void Save()
        {
            ObjectContext.SaveChanges();
        }
    }
}