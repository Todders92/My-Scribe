using Microsoft.AspNetCore.Mvc;
using MyScribe.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MyScribe.Controllers
{
  public class BoardsController : Controller
  {
    private readonly MyScribeContext _db;

    public BoardsController(MyScribeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Board> model = _db.Boards.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Board board)
    {
      _db.Boards.Add(board);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Board thisBoard = _db.Boards.FirstOrDefault(board => board.BoardId == id);
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
      return RedirectToAction("Index");
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