using RestApi.Model;
using RestApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IBookRepository _bookRepository;
        public BookBusinessImplementation(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book Create(Book book)
        {
            return _bookRepository.Create(book);
        }

        public List<Book> FindAll()
        {
            return _bookRepository.FindAll();
        }

        public Book FindByID(long id)
        {
            return _bookRepository.FindByID(id);
        }

        public Book Update(Book book)
        {
            return _bookRepository.Update(book);
        }

        public void Delete(long id)
        {
            _bookRepository.Delete(id);
        }
    }
}
