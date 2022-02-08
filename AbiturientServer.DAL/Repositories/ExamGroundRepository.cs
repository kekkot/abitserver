using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class ExamGroundRepository : EFCoreRepository<ExamGround>
    {
        private DatabaseContext db;
        public ExamGroundRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
