using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmailDispatcherApi.Infrastructure.Interfaces
{
    public  interface EntityMethods<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<int> Add(T entity);
        Task<int> Delete(int id);
        Task<int> Update(T entity); 
    }
}