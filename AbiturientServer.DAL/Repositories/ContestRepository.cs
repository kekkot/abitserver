using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class ContestRepository : EFCoreRepository<Contest>
    {
        private DatabaseContext db;
        public ContestRepository(DatabaseContext db) : base(db) 
        {
            this.db = db;
        }
    }
}
