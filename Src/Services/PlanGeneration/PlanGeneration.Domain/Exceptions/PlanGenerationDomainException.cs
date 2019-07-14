using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanGeneration.Domain.Exceptions
{
    public class PlanGenerationDomainException : Exception
    {
        public PlanGenerationDomainException()
        { }

        public PlanGenerationDomainException(string message)
            : base(message)
        { }

        public PlanGenerationDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
