

using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;

namespace PlanGeneration.BackgroundTask.IntegrationEvents
{
    public class GracePeriodConfirmedIntegrationEvent : IntegrationEvent
    {
        public int OrderId { get; }

        public GracePeriodConfirmedIntegrationEvent(int orderId) =>
            OrderId = orderId;
    }
}
