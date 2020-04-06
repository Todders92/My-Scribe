using Microsoft.AspNetCore.Mvc;
using MyScribe.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyScribe.Controllers
{
  public class PostsController : Controller
  {
    private readonly MyScribeContext _db;

    public PostsController(MyScribeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Post> model = _db.Posts.Include(posts => posts.Board).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.BoardId = new SelectList(_db.Boards, "BoardId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Post post)
    {
      _db.Posts.Add(post);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Post thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);
      return View(thisPost);
    }

    public ActionResult Edit(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);
      ViewBag.BoardId = new SelectList(_db.Boards, "BoardId", "Name");
      return View(thisPost);
    }

    [HttpPost]
    public ActionResult Edit(Post post)
    {
      _db.Entry(post).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);
      return View(thisPost);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);
      _db.Posts.Remove(thisPost);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}