using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiturientServer.DAL.Abstractions
{
    public abstract class EFCoreRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private DatabaseContext db;
        private DbSet<TEntity> dbSet;
        public EFCoreRepository(DatabaseContext db)
        {
            this.db = db;
            dbSet = db.Set<TEntity>();
        }

        public async Task AddAsync(TEntity item)
        {
            await dbSet.AddAsync(item);
        }

        public async Task AddRangeAsync(List<TEntity> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public async Task DeleteAsync(params object[] keyValues)
        {
            TEntity entity = await GetAsync(keyValues);
            if(entity != null)
            {
                dbSet.Remove(entity);
            }
        }

        public IQueryable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return dbSet.Where(predicate).AsQueryable();
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbSet;
        }

        public async Task<TEntity> GetAsync(params object[] keyValues)
        {
            return await dbSet.FindAsync(keyValues);
        }

        public void Update(TEntity item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

    }
}
