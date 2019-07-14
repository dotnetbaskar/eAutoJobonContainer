using PlanGeneration.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanGeneration.Domain.AggregatesModel.PlangenerationAggregate
{
    public interface IJobRepository : IRepository<Job>
    {
        Job Add(Job order);

        void Update(Job order);

        Task<Job> GetAsync(int orderId);
    }
}
