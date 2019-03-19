using SchooSmartLearningl.Data.Repository;
using SmartLearning.Data.Repository.IServices; 
using SmartLearning.Server.Db;
using SmartLearning.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLearning.Data.Repository.Services
{
    public class TimeTableRepository : Repository<TimeTable>, ITimeTableRepository
    {
        public TimeTableRepository(SmartDbContext dbContext):base(dbContext)
        {

        }
    }
}
