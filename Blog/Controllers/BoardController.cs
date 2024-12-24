using System.Collections.Generic;
using System.Web.Mvc;
using Blog.Models;
using Blog.Services;

namespace Blog.Controllers
{
    public class BoardController : Controller
    {
        private readonly BoardService _boardService = new BoardService();

        [HttpPost]
        public ActionResult GetBoardByBoardId(string boardId)
        {
            Board board = _boardService.GetBoardByBoardId(boardId);
            return Json(board);
        }
    }
}