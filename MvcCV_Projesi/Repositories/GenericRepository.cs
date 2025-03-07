﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using MvcCV_Projesi.Models.Entity;

namespace MvcCV_Projesi.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        DbCVEntities db = new DbCVEntities();
        public List<T> List()
        {
            return db.Set<T>().ToList();
        }

        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }

        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void TUpdate(T p)
        {
            db.SaveChanges();
        }
        public T Find(Expression<Func<T,bool>> Where)
        {
            return db.Set<T>().FirstOrDefault(Where);
        }
    }
}