using SchooSmartLearningl.Data.Repository; 
using SmartLearning.Data.Repository.IServices;
using SmartLearning.Server.Db;
using SmartLearning.Shared.Models;

namespace SmartLearning.Data.Repository.Services
{
    public class SubjectRepository : Repository<Subject>,ISubjectRepository
    {
        public SubjectRepository(SmartDbContext dbContext):base(dbContext)
        {

        }
    }
}
