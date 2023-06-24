using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary.MongoDbRepositories
{
    public class MongoDbRepository<TModel> : IRepository<TModel>
        where TModel : class
    {
        public MongoDbRepository()
        {
            // Инициализация подключения к базе данных MongoDB
        }

        public void Add(TModel obj)
        {
            // Логика добавления объекта в базу данных MongoDB
        }

        public IEnumerable<TModel> GetAll()
        {
            // Логика получения всех объектов из базы данных MongoDB
            throw new NotImplementedException();
        }

        public TModel GetById(int id)
        {
            // Логика получения объекта по идентификатору из базы данных MongoDB
            throw new NotImplementedException();
        }

        public void Remove(TModel obj)
        {
            // Логика удаления объекта из базы данных MongoDB
        }
    }
}
