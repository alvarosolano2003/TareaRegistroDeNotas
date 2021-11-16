using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class BaseModel<T> : IBase<T>
    {
        protected List<T> data;

        public BaseModel()
        {
            data = new List<T>();
        }

        public void Create(T e)
        {
            data.Add(e);
        }

        public void Delete(T e)
        {
            data.Remove(e);
        }

        public void Update(int index, T e)
        {
            data.Insert(index, e);
        }

        public List<T> GetAll()
        {
            return data;
        }

        public List<T> GetAllBy(Predicate<T> predicate)
        {
            return data.FindAll(predicate);
        }

        public T GetAnyBy(Predicate<T> predicate)
        {
            return data.Find(predicate);
        }

        
    }
}
