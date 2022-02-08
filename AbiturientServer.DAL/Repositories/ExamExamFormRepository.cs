using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class ExamExamFormRepository : EFCoreRepository<ExamExamForm>
    {
        private DatabaseContext db;
        public ExamExamFormRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
