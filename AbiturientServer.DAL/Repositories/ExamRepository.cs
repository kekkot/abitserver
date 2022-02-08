using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class ExamRepository : EFCoreRepository<Exam>
    {
        private DatabaseContext db;
        public ExamRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}