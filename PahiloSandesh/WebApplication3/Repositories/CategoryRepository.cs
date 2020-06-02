using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Repositories
{
    public class CategoryRepository:BaseRepository<Category>
    {
        public IEnumerable<CategoryList> GetAllCategory()
        {
            return StoredProcedure<CategoryList>("Sp_GetAllCategory").ToList();
        }
        public IEnumerable<CategoryList> GetAllActiveCategory()
        {
            return StoredProcedure<CategoryList>("Sp_GetAllActiveCategory").ToList();
        }
    }
}