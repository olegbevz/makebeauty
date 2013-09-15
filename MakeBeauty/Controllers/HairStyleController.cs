// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HairStyleController.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the HairStyleController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace MakeBeauty.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MakeBeauty.Data.Entities;
    using MakeBeauty.Data.Repositories;
    using MakeBeauty.Repositories;
    using MakeBeauty.ViewModels;

    using System.Web.Mvc;

    public class HairStyleController : Controller
    {
        private HairStyleRepository _hairStyleRepository = new HairStyleRepository(new MakeBeautyEntities());

        private CommentRepository _commentRepository = new CommentRepository(new MakeBeautyEntities());

        private ImageRepository _imageRepository = new ImageRepository();
        
        public ActionResult Index()
        {
            var grid = new Grid<HairStyle>(_hairStyleRepository.GetAll()) { Columns = 4 };

            return View(grid);
        }

        //
        // GET: /HairStyle/Details/5

        public ActionResult Details(int id)
        {
           var hairStyle = _hairStyleRepository.GetById(id);

            if (hairStyle != null)
            {
                return View(new HairStyleViewModel(hairStyle)
                    {
                        Comments = _hairStyleRepository.GetHairStyleComments(id),
                        BigImages = _hairStyleRepository.GetHairStyleImages(id)
                    });
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Details(int id, Comment comment)
        {
            _commentRepository.AddComment(comment);

            _hairStyleRepository.RegisterHairStyleComment(id, comment);

            var hairStyle = _hairStyleRepository.GetById(id);

            var comments = _hairStyleRepository.GetHairStyleComments(id);

            return View(new HairStyleViewModel(hairStyle)
                {
                    Comments = comments,
                    BigImages = _hairStyleRepository.GetHairStyleImages(id)
                });
        }

        //
        // GET: /HairStyle/Create
        [Authorize]
        public ActionResult Create()
        {
            var hairStyle = new HairStyle();

            var allImages = _imageRepository.GetAllImages(Server);
            
            return View(new HairStyleViewModel(hairStyle, allImages)
                {
                    BigImages = new List<string>(),
                    SmallImage = allImages.First()
                });
        } 

        //
        // POST: /HairStyle/Create

        [HttpPost]
        [Authorize]
        public ActionResult Create(HairStyleViewModel hairStyle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _hairStyleRepository.Insert(hairStyle.GetOriginalSource());

                    return RedirectToAction("Index");
                }

                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        
        //
        // GET: /HairStyle/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            var hairStyle = _hairStyleRepository.GetById(id);

            var images = _imageRepository.GetAllImages(Server);

            if (hairStyle != null)
            {
                return View(new HairStyleViewModel(hairStyle, images)
                    {
                        Comments = _hairStyleRepository.GetHairStyleComments(id)
                    });
            }

            return RedirectToAction("Index");
        }

        //
        // POST: /HairStyle/Edit/5

        [HttpPost]
        [Authorize]
        public ActionResult Edit(int id, HairStyleViewModel hairStyle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var source = hairStyle.GetOriginalSource();

                    source.id = id;

                    _hairStyleRepository.Update(source);

                    return RedirectToAction("Index");
                }
 
                return View();
            } 
            catch (Exception ex)
            {
                return View();
            }
        }

        //
        // GET: /HairStyle/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            _hairStyleRepository.Delete(id);

            return View("Index", _hairStyleRepository.GetAll());
        }

        [Authorize]
        public ActionResult DeleteComment(int id)
        {
            var hairStyle = _hairStyleRepository.GetHairStyleByCommentId(id);

            _commentRepository.DeleteComment(id);

            return RedirectToAction("Details", new { hairStyle.id });
        }
    }
}
