using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class ApplicationAbiturientExamRepository : EFCoreRepository<ApplicationAbiturientExam>
    {
        private DatabaseContext db;
        public ApplicationAbiturientExamRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
