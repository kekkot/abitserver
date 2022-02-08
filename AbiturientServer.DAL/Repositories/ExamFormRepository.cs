using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class ExamFormRepository : EFCoreRepository<ExamForm>
    {
        private DatabaseContext db;
        public ExamFormRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
