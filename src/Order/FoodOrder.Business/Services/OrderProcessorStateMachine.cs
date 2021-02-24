using System;
using System.Threading.Tasks;
using Automatonymous;
using Automatonymous.Binders;
using FoodOrder.Business.Events;
using FoodOrder.Shared.Models;
using FoodOrder.Shared.Models.Command;
using FoodOrder.Shared.Models.IntegrationEvents;
using FoodOrder.Shared.Models.Models;

namespace FoodOrder.Business.Services
{
    public class OrderProcessorStateMachine: MassTransitStateMachine<ProcessingOrderState>
    {
        public OrderProcessorStateMachine()
        {
            this.InstanceState(x => x.State);
            this.State(() => Processing);
            this.ConfigureCorrelationIds();
            this.Initially(SetOrderSubmittedHandler());
            this.During(Processing, SetPaymentProcessedHandler(), this.SetOrderPreparedHandler(), SetOrderDeliveredHandler());
            SetCompletedWhenFinalized();
        }
        private void ConfigureCorrelationIds()
        {
            this.Event(() => OrderSubmitted, x => x.CorrelateById(c => c.Message.CorrelationId).SelectId(c => c.Message.CorrelationId));
            this.Event(() => PaymentProcessed, x => x.CorrelateById(c => c.Message.CorrelationId));
            this.Event(() => OrderPrepared, x => x.CorrelateById(c => c.Message.CorrelationId));
            this.Event(() => OrderDelivered, x => x.CorrelateById(c => c.Message.CorrelationId));
            this.Event(() => OrderCancelled, x => x.CorrelateById(c => c.Message.CorrelationId));
            this.Event(() => OrderProcessed, x => x.CorrelateById(c => c.Message.CorrelationId));
        }
        private EventActivityBinder<ProcessingOrderState, IOrderSubmitted> SetOrderSubmittedHandler() =>
            When(OrderSubmitted).Then(c => UpdateSagaState(c.Instance, c.Data.Order))
                .ThenAsync(c => this.SendCommand<IProcessPayment>("order-payment", c))
                .TransitionTo(Processing);
        private EventActivityBinder<ProcessingOrderState, IPaymentProcessed> SetPaymentProcessedHandler() =>
            When(PaymentProcessed).Then(c => UpdateSagaState(c.Instance, c.Data.Order))
                .ThenAsync(c => this.SendCommand<IPrepareOrder>("order-restaurant", c))
                .TransitionTo(Processing);
        private EventActivityBinder<ProcessingOrderState, IOrderPrepared> SetOrderPreparedHandler() =>
            When(OrderPrepared).Then(c => UpdateSagaState(c.Instance, c.Data.Order))
                .ThenAsync(c => this.SendCommand<IDeliverOrder>("order-delivery", c))
                .TransitionTo(Processing);

        private EventActivityBinder<ProcessingOrderState, IOrderDelivered> SetOrderDeliveredHandler() =>
            When(OrderDelivered).Then(c =>
                {
                    UpdateSagaState(c.Instance, c.Data.Order);
                    c.Instance.Order.Status = Status.Delivered;
                })
                .Publish(c => new OrderProcessed(c.Data.CorrelationId, c.Data.Order))
                .Finalize();

        //TODO action when order canceled or some step failed
        private static void UpdateSagaState(ProcessingOrderState state, Order order)
        {
            var currentDate = DateTime.Now;
            state.Created = currentDate;
            state.Updated = currentDate;
            state.Order = order;
        }
        private async Task SendCommand<TCommand>(string endpointKey, BehaviorContext<ProcessingOrderState, IMessage> context)
            where TCommand : class, IMessage
        {
            var sendEndpoint = await context.GetSendEndpoint(new Uri("sagas-demo-order-processor"));
            await sendEndpoint.Send<TCommand>(new
            {
                CorrelationId = context.Data.CorrelationId,
                Order = context.Data.Order
            });
        }
        public State Processing { get; private set; }

        public Event<IOrderSubmitted> OrderSubmitted { get; private set; }
        public Event<IPaymentProcessed> PaymentProcessed { get; set; }
        public Event<IOrderPrepared> OrderPrepared { get; private set; }
        public Event<IOrderDelivered> OrderDelivered { get; private set; }
        public Event<IOrderProcessed> OrderProcessed { get; private set; }
        public Event<IOrderCancelled> OrderCancelled { get; private set; }
    }
}
