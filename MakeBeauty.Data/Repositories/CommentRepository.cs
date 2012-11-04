// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommentRepository.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the CommentRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MakeBeauty.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MakeBeauty.Data.Entities;

    public class CommentRepository
    {
        private MakeBeautyEntities _entities;

        public CommentRepository(MakeBeautyEntities entities)
        {
            _entities = entities;
        }

        public IEnumerable<Comment> GetAllComments()
        {
            return _entities.Comments;
        }

        public Comment GetCommentById(int id)
        {
            return _entities.Comments.FirstOrDefault(comment => comment.id == id);
        }

        public bool Has(Comment comment)
        {
            return _entities.Comments.Any(c => c.id == comment.id);
        }

        public void AddComment(Comment comment)
        {
            if (_entities.Comments.Any())
            {
                comment.id = _entities.Comments.Max(n => n.id) + 1;
            }

            comment.date = DateTime.Now;

            _entities.Comments.AddObject(comment);

            _entities.SaveChanges();
        }

        public void DeleteComment(int id)
        {
            var comment = GetCommentById(id);

            if (comment != null)
            {
                foreach (var pair in _entities.HairStyle_Comment.Where(p => p.comment_id == id))
                {
                    _entities.HairStyle_Comment.DeleteObject(pair);
                }

                _entities.Comments.DeleteObject(comment);

                _entities.SaveChanges();
            }
        }
    }
}