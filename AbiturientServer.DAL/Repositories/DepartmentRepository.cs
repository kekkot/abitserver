using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class DepartmentRepository : EFCoreRepository<Department>
    {
        private DatabaseContext db;
        public DepartmentRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}