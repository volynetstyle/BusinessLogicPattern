using AutoMapper;

namespace PatternLibrary.Abstractions
{
    public class Service<TModel, TService> : IService<TService>
        where TModel : class 
        where TService : class
    {
        private readonly IMapper _mapper;
        private readonly IRepository<TModel> _repository;

        public Service(IMapper mapper, IRepository<TModel> repository) 
        { 
            _mapper = mapper;
            _repository = repository;
        }

        public void Add(TService obj)
        {
            _repository.Add(_mapper.Map<TModel>(obj));  
        }

        public IEnumerable<TService> GetAll()
        {
            return _mapper.Map<IEnumerable<TService>>(_repository.GetAll());
        }

        public TService GetById(int id)
        {
            return _mapper.Map<TService>(_repository.GetById(id));
        }

        public void Remove(TService obj)
        {
            _repository.Remove(_mapper.Map<TModel>(obj));
        }
    }
}
