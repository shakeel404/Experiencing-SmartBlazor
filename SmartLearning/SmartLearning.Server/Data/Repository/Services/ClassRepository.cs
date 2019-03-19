using SchooSmartLearningl.Data.Repository;
using SmartLearning.Data.Repository.IServices;
using SmartLearning.Server.Db;
using SmartLearning.Shared.Models; 

namespace SmartLearning.Data.Repository.Services
{
    public class ClassRepository : Repository<Class>,IClassRepository
    {
        public ClassRepository(SmartDbContext dbContext) : base(dbContext)
        {

        }
    }
}
