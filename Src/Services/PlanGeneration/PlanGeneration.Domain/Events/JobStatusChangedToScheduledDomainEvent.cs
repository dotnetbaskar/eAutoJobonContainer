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
    public class JobStatusChangedToScheduledDomainEvent
         : INotification
    {
        public int JobId { get; }
       

        public JobStatusChangedToScheduledDomainEvent(int jid)
        {
            JobId = jid;
           
        }
    }
}
