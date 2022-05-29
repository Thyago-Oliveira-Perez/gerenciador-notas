using FluentValidation;
using Model.Domain.Entities;
using System.Collections.Generic;

namespace Model.Domain.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity obj);

        void Delete(int id);

        IList<TEntity> Get();

        TEntity GetById(int id);

        void Update(TEntity obj);
    }
}
