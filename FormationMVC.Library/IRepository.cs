using System;
using System.Collections.Generic;
namespace FormationMVC.Library
{
    public interface IRepository<T>
    {
        ProductContext Context { get; set; }
        void Create(T vr);
        void Delete(T vr);
        void Delete(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Save();
    }
}
