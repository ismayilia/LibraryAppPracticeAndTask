using Domain.Common;
using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Repositories
{
    // Baserepo yaradiriq, onun i/f-i  ve classi. IBasereopo crud ishlerini butun tipler ucun oz ishin gorur,

    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public void Create(T entity) // entity parametrin adi
        {
            AppDbContext<T>.datas.Add(entity); //generic liste add edir. Entity paramaetrin adi
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return AppDbContext<T>.datas;
        }

        public List<T> GetAllByExpression(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return AppDbContext<T>.datas.FirstOrDefault(m => m.Id == id);
            //Library colden gelecek. datasin icinden firstordefault ele m.Id-i buna beraber olana                                                                
        }

        public List<T> SearchByName(string name)
        {
            return AppDbContext<T>.datas.FindAll(m => m.Equals(name)).ToList();
        }
    }
}
