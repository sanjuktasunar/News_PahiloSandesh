using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Repositories
{
    public partial class ParentCategoryRepository:BaseRepository<ParentCategory>
    {
        public IEnumerable<ParentCategory> GetAllParentCategory()
        {
            return StoredProcedure<ParentCategory>("Sp_GetAllParentCategory").ToList();
        }
        public IEnumerable<ParentCategory> GetAllActiveParentCategory()
        {
            return StoredProcedure<ParentCategory>("Sp_GetAllActiveParentCategory").ToList();
        }
    }
}