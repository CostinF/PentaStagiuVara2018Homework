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
            ViewBag.PageCreateDate = DateTime.Now;
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

        [HttpGet]
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
        public ActionResult Edit(int id)
        {
            Post post = posts.Find(p => p.Id == id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }
        [HttpPost]
        public ActionResult Edit(Post post)
        {
            Post postFromList = posts.Find(p => p.Id == post.Id);
            postFromList.Message = post.Message;
            postFromList.PostType = post.PostType;
            postFromList.IsSticky = post.IsSticky;
            postFromList.Priority = post.Priority;

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
            post.TimeOfPosting = DateTime.Now;
            posts.Add(post);
            return RedirectToAction("Index");
        }

    }
}