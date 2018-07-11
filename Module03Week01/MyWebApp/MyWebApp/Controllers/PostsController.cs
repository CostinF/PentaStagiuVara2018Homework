using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class PostsController : Controller
    {
        public static List<Post> posts = new List<Post>();
        public static int Id = 0;

        // GET: Posts
        public ActionResult Index()
        {
            return View(posts);
        }

        public ActionResult Details(int id)
        {
            Post post = posts.Find(p => p.Id == id);
            if (post.Message == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        public ActionResult Delete(int id)
        {
            Post post = posts.Find(p => p.Id == id);
            if (post == null)
            {
                return HttpNotFound();
            }
            posts.Remove(post);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Post post)
        {
            Id++;
            post.Id = Id;
            posts.Add(post);
            return RedirectToAction("Index");
        }

    }
}