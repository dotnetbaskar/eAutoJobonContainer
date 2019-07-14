using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using PlanGeneration.Domain.AggregatesModel.PlangenerationAggregate;

namespace PlanGeneration.Domain.Events
{
    public class PlangenerationstartedDomainEvent : INotification
    {
        public int jobid { get; }
        public string jobstatus { get; }       
       

        public PlangenerationstartedDomainEvent(int jid, string status)
        {
            
            jobid = jid;
            jobstatus = status;
           
        }
    }
}
