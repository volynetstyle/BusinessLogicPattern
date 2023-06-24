using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    public interface IBaseInterface<T>
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public void Remove(T obj);
        public void Add(T obj);
    }
}
