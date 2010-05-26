using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ujs.Models;

namespace ujs.Controllers
{
    public class CommentsController : Controller
    {
        public CommentsController()
        {
            Comments =  new List<Comments>()
                             {
                                 new Comments{Id = 1,Title = "Comment # 1", Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Morbi malesuada, ante at feugiat tincidunt, enim massa gravida metus, commodo lacinia massa diam vel eros. Proin eget urna. Nunc fringilla neque vitae odio. Vivamus vitae ligula."},
                                 new Comments{Id = 2,Title = "Comment # 2", Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Morbi malesuada, ante at feugiat tincidunt, enim massa gravida metus, commodo lacinia massa diam vel eros. Proin eget urna. Nunc fringilla neque vitae odio. Vivamus vitae ligula."},
                                 new Comments{Id =3,Title = "Comment # 3", Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Morbi malesuada, ante at feugiat tincidunt, enim massa gravida metus, commodo lacinia massa diam vel eros. Proin eget urna. Nunc fringilla neque vitae odio. Vivamus vitae ligula."},
                                 new Comments{Id = 4,Title = "Comment # 4", Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Morbi malesuada, ante at feugiat tincidunt, enim massa gravida metus, commodo lacinia massa diam vel eros. Proin eget urna. Nunc fringilla neque vitae odio. Vivamus vitae ligula."},
                                 new Comments{Id = 5,Title = "Comment # 5", Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Morbi malesuada, ante at feugiat tincidunt, enim massa gravida metus, commodo lacinia massa diam vel eros. Proin eget urna. Nunc fringilla neque vitae odio. Vivamus vitae ligula."},
                                 new Comments{Id = 6,Title = "Comment # 6", Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Morbi malesuada, ante at feugiat tincidunt, enim massa gravida metus, commodo lacinia massa diam vel eros. Proin eget urna. Nunc fringilla neque vitae odio. Vivamus vitae ligula."},
                                 new Comments{Id = 7,Title = "Comment # 7", Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Morbi malesuada, ante at feugiat tincidunt, enim massa gravida metus, commodo lacinia massa diam vel eros. Proin eget urna. Nunc fringilla neque vitae odio. Vivamus vitae ligula."},
                                 new Comments{Id = 8,Title = "Comment # 8", Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Morbi malesuada, ante at feugiat tincidunt, enim massa gravida metus, commodo lacinia massa diam vel eros. Proin eget urna. Nunc fringilla neque vitae odio. Vivamus vitae ligula."},
                                 new Comments{Id = 9,Title = "Comment # 9", Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Morbi malesuada, ante at feugiat tincidunt, enim massa gravida metus, commodo lacinia massa diam vel eros. Proin eget urna. Nunc fringilla neque vitae odio. Vivamus vitae ligula."},
                                 new Comments{Id = 10,Title = "Comment # 10", Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Morbi malesuada, ante at feugiat tincidunt, enim massa gravida metus, commodo lacinia massa diam vel eros. Proin eget urna. Nunc fringilla neque vitae odio. Vivamus vitae ligula."}
                             };
            
            
        }
        //
        // GET: /Comments/
        private List<Comments> Comments;
        
        public ActionResult Index()
        {
            return View(Comments);
        }

        public ActionResult Delete(int id)
        {
            var itemToRemove = Comments.First(c => c.Id == id);
            Comments.Remove(itemToRemove);
            return View("Index",Comments);
        }
    }
}
