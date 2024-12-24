using System.Collections.Generic;
using System.Linq;
using Blog.Models;
using Dapper;

namespace Blog.Repositories
{
    public class BoardRepository
    {
        private readonly DatabaseContext _dbContext;

        public BoardRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public Board GetBoardByBoardId(string boardId)
        {
            using (var connection = _dbContext.CreateConnection())
            {
                string query = "SELECT board_id, title, content FROM Board WHERE board_id = @boardId";
                return connection.QuerySingle<Board>(query, new { boardId = boardId });
            }
        }
        
        public List<MostView> GetMostViewList() 
        {
            using (var connection = _dbContext.CreateConnection())
            {
                string query = "SELECT board_id, title, content FROM Board LIMIT @limit";
                return connection.Query<MostView>(query, new { limit = 3 }).ToList();
            }
        }
    }
}