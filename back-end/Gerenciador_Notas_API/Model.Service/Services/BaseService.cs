using Model.Domain.Entities;
using Model.Domain.Interfaces;
using System.Collections.Generic;

namespace Model.Service.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Add(TEntity obj)
        {
            _baseRepository.Insert(obj);
        }

        public void Delete(int id) => _baseRepository.Delete(id);

        public IList<TEntity> Get() => _baseRepository.GetAll();

        public TEntity GetById(int id) => _baseRepository.GetById(id);

        public void Update(TEntity obj)
        {
            _baseRepository.Update(obj);
        }
    }
}
