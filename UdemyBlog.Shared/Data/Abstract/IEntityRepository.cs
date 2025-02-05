﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UdemyBlog.Shared.Entities.Abstract;

namespace UdemyBlog.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        Task<T> GetAsync(Expression<Func<T,bool>> predicate,params Expression<Func<T, object>>[] includeProperties); // var kullanici = repository.GetAsync(k=>k.Iq==15);
        //25 id'li makaleyi getirirken, makale ile birlikte kullaniciyi ve yorumlarida include etmek(birlikte getirmek) istiyoruz
        //var makale = repository.GetAsync(m => m.Id == 25, m => m.User, m =»m.Comments);

        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, params Expression<Func<T, object>>[] includeProperties);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

    }
}
