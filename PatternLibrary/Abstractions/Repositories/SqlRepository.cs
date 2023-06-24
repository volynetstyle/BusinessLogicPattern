using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary.SqlRepositories
{
    public class SqlRepository<TModel> : IRepository<TModel>
        where TModel : class
    {
        public SqlRepository()
        {
            // Инициализация подключения к базе данных SQL Server
        }

        public void Add(TModel obj)
        {
            // Логика добавления объекта в базу данных SQL Server
        }

        public IEnumerable<TModel> GetAll()
        {
            // Логика получения всех объектов из базы данных SQL Server
            throw new NotImplementedException();
        }

        public TModel GetById(int id)
        {
            // Логика получения объекта по идентификатору из базы данных SQL Server
            throw new NotImplementedException();
        }

        public void Remove(TModel obj)
        {
            // Логика удаления объекта из базы данных SQL Server
        }
    }
}
