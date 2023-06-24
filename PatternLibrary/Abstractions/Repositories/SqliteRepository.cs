using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary.SqliteRepositories
{
    public class SqliteRepository<TModel> : IRepository<TModel>
        where TModel : class
    {
        public SqliteRepository()
        {
            // Инициализация подключения к базе данных SQLite
        }

        public void Add(TModel obj)
        {
            // Логика добавления объекта в базу данных SQLite
        }

        public IEnumerable<TModel> GetAll()
        {
            // Логика получения всех объектов из базы данных SQLite
            throw new NotImplementedException();
        }

        public TModel GetById(int id)
        {
            // Логика получения объекта по идентификатору из базы данных SQLite
            throw new NotImplementedException();
        }

        public void Remove(TModel obj)
        {
            // Логика удаления объекта из базы данных SQLite
        }
    }
}
