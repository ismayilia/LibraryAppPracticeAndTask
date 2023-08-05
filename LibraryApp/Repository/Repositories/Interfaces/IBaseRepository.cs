using Domain.Common;
using System;
using System.Collections.Generic; 
using System.Linq.Expressions;

namespace Repository.Repositories.Interfaces
{
    
   
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity); // entity type-in adi
        void Delete(T entity);
        void Edit(T entity);
        T GetById(int Id);
        List<T> GetAll();
        List<T> GetAllByExpression(Expression<Func<T, bool>> expression); //Search method true false qaytaran
        List<T> SearchByName(string name);

    }
}
