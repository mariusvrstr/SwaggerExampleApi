using SwaggerApi.StubData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SwaggerApi.Common
{
    public class BookRepositoryStub
    {
        private List<Book> _table;

        public BookRepositoryStub()
        {
            _table = new List<Book>();

            _table.Add(new BookBuilder(null).FiveDysfunctionsOfATeam().Build());
            _table.Add(new BookBuilder(null).PhoenixProject().Build());
            _table.Add(new BookBuilder(null).RadicalCandor().Build());
        }

        public Book GetById(Guid id)
        {
            return _table.Single(b => b.Id == id);
        }

        public IEnumerable<Book> FindAll()
        {
            return _table;
        }

        public IEnumerable<Book> FindByTitle(string title)
        {
            return _table.Where(t => t.Title.ToLower().Contains(title.ToLower()));
        }

        public Book Add(Book entity)
        {
            if (entity.Id == Guid.Empty)
            {
                entity.Id = Guid.NewGuid();
            }

            _table.Add(entity);

            return entity;
        }

        public Book Update(Guid id, Book entity)
        {
            if (id != entity.Id)
            {
                throw new Exception($"Invalid update request. The ID [{id}] is different from the object provided");
            }

            var foundEntity = _table.Single(t => t.Id == id);

            foundEntity = entity;
 
            return foundEntity;
        }

        public void Remove(Guid id)
        {
            var foundEntity = _table.Single(t => t.Id == id);

            _table.Remove(foundEntity);
        }
    }
}