using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class DocumentExamGradeRepository : EFCoreRepository<DocumentExamGrade>
    {
        private DatabaseContext db;
        public DocumentExamGradeRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
