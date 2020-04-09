using Microsoft.AspNetCore.Mvc;
using MyScribe.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System;

namespace MyScribe.Controllers
{
  [Authorize]
  public class BoardsController : Controller
  {
    private readonly MyScribeContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public BoardsController(MyScribeContext db, UserManager<ApplicationUser> userManager)
    {
      _db = db;
      _userManager = userManager;
    }

    public async Task<ActionResult> Index()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userBoards = _db.Boards.Where(board => board.User.Id == currentUser.Id);
      return View(userBoards);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Board board)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      board.User = currentUser;
      _db.Boards.Add(board);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Board thisBoard = _db.Boards.FirstOrDefault(board => board.BoardId == id);
      thisBoard.Posts = _db.Posts.Where(p => p.BoardId == id).ToList();
      // var orderedPosts = _db.Posts.Where(p => p.BoardId == id).ToList().OrderedByDescending(post => post.Importance);
      var orderedPosts = thisBoard.Posts.OrderByDescending(post => post.Pin);
      ViewBag.Posts = orderedPosts.ToList();
      return View(thisBoard);
    }

    public ActionResult Edit(int id)
    {
      var thisBoard = _db.Boards.FirstOrDefault(board => board.BoardId == id);
      return View(thisBoard);
    }

    [HttpPost]
    public ActionResult Edit(Board board)
    {
      _db.Entry(board).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new {id= board.BoardId});
    }

    public ActionResult Delete(int id)
    {
      var thisBoard = _db.Boards.FirstOrDefault(board => board.BoardId == id);
      return View(thisBoard);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisBoard = _db.Boards.FirstOrDefault(board => board.BoardId == id);
      _db.Boards.Remove(thisBoard);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
