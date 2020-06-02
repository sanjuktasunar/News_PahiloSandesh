using Dapper;
using DapperExtensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        //protected BaseRepository()
        //{
        //    if (db.State == ConnectionState.Closed)
        //        db.Open();
        //}

        //protected IdbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString);

        public int Execute(string sql, object param)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Execute(sql, param);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public IEnumerable<dynamic> Query(string sql, object param = null)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Query(sql, param);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public IEnumerable<object> Query(Type type, string sql, object param = null)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Query(type, sql, param);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public IEnumerable<TEntity> Query<TEntity>(CommandDefinition command)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Query<TEntity>(command);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public IEnumerable<TEntity> Query<TEntity>(string sql, object param = null)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Query<TEntity>(sql, param);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public IEnumerable<TEntity> StoredProcedure<TEntity>(string sql, object param = null)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Query<TEntity>(sql, param, commandType: CommandType.StoredProcedure);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public int StoredProcedure(string sql, object param = null)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Execute(sql, param, commandType: CommandType.StoredProcedure);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public T Get(object id)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    return db.Get<T>(id);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public IEnumerable<T> GetList()
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.GetList<T>();
                }
                finally
                {
                    db.Close();
                }
            }
        }

        // ReSharper disable once MethodOverloadWithOptionalParameter
        public IEnumerable<T> GetList(object predicate = null, IList<ISort> sort = null)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.GetList<T>(predicate, sort);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public IEnumerable<T> GetPage(object predicate = null, IList<ISort> sort = null, int page = 1, int resultsPerPage = 10)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.GetPage<T>(predicate, sort, page, resultsPerPage);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public int Count(object predicate)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Count<T>(predicate);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public dynamic Insert(T obj)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Insert(obj);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public void Insert(IEnumerable<T> obj)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    db.Insert(obj);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public bool Update(T obj)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Update(obj);
                }
                finally
                {
                    db.Close();
                }
            }

        }

        public bool Update(IEnumerable<T> obj)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Update(obj);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public bool Delete(object id)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Delete(Get(id));
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public bool Delete(Predicate<T> predicate)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Delete(predicate);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        public void Dispose()
        {
            //GC.Collect();
            GC.SuppressFinalize(this);
        }

        //protected void Dispose(bool disposing)
        //{
        //    if (!disposing) return;
        //    if (db == null) return;
        //    db.Dispose();
        //    db = null;
        //}

        ~BaseRepository()
        {
            Dispose();
        }
    }
}