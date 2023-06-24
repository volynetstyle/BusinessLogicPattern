using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    public interface IRepository<TModel> : IBaseInterface<TModel> 
        where TModel : class
    {
    }
}
