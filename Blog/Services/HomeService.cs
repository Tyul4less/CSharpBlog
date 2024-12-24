using System.Collections.Generic;
using System.Configuration;
using Blog.Models;
using Blog.Repositories;
using MySql.Data.MySqlClient;

namespace Blog.Services
{
    public class HomeService
    {
        private readonly BoardRepository _boardRepository;
        
        public HomeService()
        {
            _boardRepository = new BoardRepository(GlobalContext.DbContext);
        }

        public List<MostView> GetMostViewList()
        {
            return _boardRepository.GetMostViewList();
        }
    }
}