using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    public interface IService<TService> : IBaseInterface<TService> where TService : class
    {
    }
}
