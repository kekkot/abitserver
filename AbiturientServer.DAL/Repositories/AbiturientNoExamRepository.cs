using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class AbiturientNoExamRepository : EFCoreRepository<AbiturientNoExam>
    {
        private DatabaseContext db;
        public AbiturientNoExamRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
