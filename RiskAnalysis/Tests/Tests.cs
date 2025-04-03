using Moq;
using RiskAnalysis;
using RiskAnalysis.Domain;
using RiskAnalysis.Events;
using RiskAnalysis.Events.Abstractions;
using RiskAnalysis.Notifications;
using Shouldly;
using Xunit;

namespace Tests;

public class Tests
{
    public class BuyerRequestedSupplier
    {
        
        [Fact]
        public async Task MultipleSuppliersRequestedInSingleDay_ShouldNotify()
        {
            var setup = CreateSetup();
            var buyerId = new BuyerId(10);
            SupplierId[] suppliers = [new(20), new(30), new(40), new(50)];

            var userId = new UserId(10);
       
            var events = suppliers.Select(supplierId => new BuyerRequestedSupplierEvent(buyerId, supplierId));

            foreach (var e in events)
            {
                var meta = new EventMetadata(userId, DateTime.Now);
                await setup.Handler.Handle(e, meta, CancellationToken.None);
            }

            setup.Notifications.Invocations.ShouldHaveSingleItem();
        }
    
        [Fact]
        public async Task SingleSuppliersRequested_ShouldNotNotify()
        {
            var setup = CreateSetup();
            var buyerId = new BuyerId(10);
            var supplierId = new SupplierId(20);

            var userId = new UserId(10);
       
            var e = new BuyerRequestedSupplierEvent(buyerId, supplierId);
        
            var meta = new EventMetadata(userId, DateTime.Now);
            await setup.Handler.Handle(e, meta, CancellationToken.None);

            setup.Notifications.Invocations.ShouldBeEmpty();
        }
    }

    public static Setup CreateSetup()
    {
        return new(new(), new Mock<INotificationService>());
    }

    public record Setup(Handler Handler, Mock<INotificationService> Notifications);
}