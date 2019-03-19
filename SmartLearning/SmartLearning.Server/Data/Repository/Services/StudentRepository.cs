using SmartLearning.Data.Repository.IServices;
using SchooSmartLearningl.Data.Repository;
using SmartLearning.Shared.Models;
using SmartLearning.Server.Db;

namespace SmartLearning.Data.Repository.Services
{
    public class StudentRepository :Repository<Student>, IStudentRepository
    {
        public StudentRepository(SmartDbContext dbContext):base(dbContext)
        {

        }
    }
}
