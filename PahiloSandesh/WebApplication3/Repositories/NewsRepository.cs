using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Repositories
{
    public class NewsRepository:BaseRepository<News>
    {
        public IEnumerable<NewsList> GetAllNews()
        {
            return StoredProcedure<NewsList>("Sp_GetAllNews").ToList();
        }
    }
}