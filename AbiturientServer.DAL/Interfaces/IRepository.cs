using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiturientServer.DAL.Interfaces
{
    interface IRepository<Entity>
    {
        IQueryable<Entity> GetAll();
        IQueryable<Entity> Find(Func<Entity, bool> predicate);
        Task<Entity> GetAsync(params object[] keyValues);
        Task AddAsync(Entity item);
        void Update(Entity item);
        Task DeleteAsync(params object[] keyValues);
    }
}
