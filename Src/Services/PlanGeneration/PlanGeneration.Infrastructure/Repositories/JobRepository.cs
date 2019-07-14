using Microsoft.EntityFrameworkCore;
using PlanGeneration.Domain.AggregatesModel.PlangenerationAggregate;
using PlanGeneration.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanGeneration.Infrastructure.Repositories
{
    public class JobRepository
        : IJobRepository
    {
        private readonly JobContext _context;

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public JobRepository(JobContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Job Add(Job order)
        {
            return _context.Orders.Add(order).Entity;

        }

        public async Task<Job> GetAsync(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order != null)
            {
                await _context.Entry(order)
                    .Collection(i => i.OrderItems).LoadAsync();
                await _context.Entry(order)
                    .Reference(i => i.OrderStatus).LoadAsync();
                await _context.Entry(order)
                    .Reference(i => i.Address).LoadAsync();
            }

            return order;
        }

        public void Update(Job order)
        {
            _context.Entry(order).State = EntityState.Modified;
        }
    }
}
