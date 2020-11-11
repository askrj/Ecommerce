using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface InterfaceGenericaApp<T> where T : class
    {
        Task Add(T objeto);
        Task UpDate(T objeto);
        Task Delete(T objeto);
        Task<T> GetEntityByID(int Id);
        Task<List<T>> List();
    }
}
