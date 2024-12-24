using System.Collections.Generic;
using System.Configuration;
using Blog.Models;
using Blog.Repositories;
using MySql.Data.MySqlClient;

namespace Blog.Services
{
    public class BoardService
    {
        private readonly BoardRepository _boardRepository;
        
        public BoardService()
        {
            _boardRepository = new BoardRepository(GlobalContext.DbContext);
        }
        
        public Board GetBoardByBoardId(string boardId)
        {
            return _boardRepository.GetBoardByBoardId(boardId);
        }
    }
}