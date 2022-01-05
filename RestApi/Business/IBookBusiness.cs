using RestApi.Data.DTO;
using RestApi.Model;
using System.Collections.Generic;

namespace RestApi.Business
{
    public interface IBookBusiness
    {
        BookDTO Create(BookDTO book);
        BookDTO FindByID(long id);
        List<BookDTO> FindAll();
        BookDTO Update(BookDTO book);
        void Delete(long id);
    }
}
