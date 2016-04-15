using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedditLab.Models;

namespace RedditLab.Controllers
{
    public class PostsController : Controller
    {
        private RedditLabDbContext db = new RedditLabDbContext();
        // GET: Posts
        public ActionResult Index()
        {
            return View(db.Posts.ToList());
        }
    }
}