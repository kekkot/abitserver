using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class NoExamRepository : EFCoreRepository<NoExam>
    {
        private DatabaseContext db;
        public NoExamRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
