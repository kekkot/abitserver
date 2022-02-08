using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class AbiturientExamRepository : EFCoreRepository<AbiturientExam>
    {
        private DatabaseContext db;
        public AbiturientExamRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
