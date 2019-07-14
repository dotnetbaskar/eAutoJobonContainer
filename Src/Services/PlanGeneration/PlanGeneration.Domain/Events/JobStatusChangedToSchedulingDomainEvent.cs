using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanGeneration.Domain.Events
{
    using MediatR;
    using System.Collections.Generic;

    /// <summary>
    /// Event used when the grace period order is confirmed
    /// </summary>
    public class JobStatusChangedToSchedulingDomainEvent
         : INotification
    {
        public int JobId { get; }
       

        public JobStatusChangedToSchedulingDomainEvent(int jid)
        {
            JobId = jid;
           
        }
    }
}
