using RestApi.Model.Base;
using System.Collections.Generic;

namespace RestApi.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T obj);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T obj);
        void Delete(long id);
        bool Exists(long id);
    }
}
