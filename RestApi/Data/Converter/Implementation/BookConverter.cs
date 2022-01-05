using RestApi.Data.Converter.Contract;
using RestApi.Data.DTO;
using RestApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestApi.Data.Converter.Implementation
{
    public class BookConverter : IParser<BookDTO, Book>, IParser<Book, BookDTO>
    {
        public BookDTO Parse(Book origin)
        {
            if (origin == null)
                return null;
            else
                return new BookDTO
                {
                    Id = origin.Id,
                    Author = origin.Author,
                    LaunchDate = origin.LaunchDate,
                    Price = origin.Price,
                    Title = origin.Title
                };
        }

        public Book Parse(BookDTO origin)
        {
            if (origin == null)
                return null;
            else
                return new Book
                {
                    Id = origin.Id,
                    Author = origin.Author,
                    LaunchDate = origin.LaunchDate,
                    Price = origin.Price,
                    Title = origin.Title
                };
        }

        public List<BookDTO> Parse(List<Book> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(item => Parse(item)).ToList();
        }

        public List<Book> Parse(List<BookDTO> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(item => Parse(item)).ToList();
        }
    }
}
