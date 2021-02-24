using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FoodOrder.Api.Models;
using FoodOrder.Business.Command;
using FoodOrder.Business.Query;
using MediatR;

namespace FoodOrder.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Create food order.
        /// </summary>
        /// <param name="orderRequest">Order parameters.</param>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateOrders([FromBody] OrderRequest orderRequest, CancellationToken token = default)
        {
            //TODO add validation
            await _mediator.Publish(new CreateOrdersCommand(orderRequest.ClientId, 
                orderRequest.Orders.Select(x=>
                    (x.RestaurantId,x.Items.Select(c=>c.MenuItemId).ToArray())).ToList()), token);
            return Ok();
        }

        /// <summary>
        /// Get order details and status.
        /// </summary>
        /// <param name="id">Order Id.</param>
        /// <param name="token"></param>
        /// <returns>OrderDto</returns>
        [HttpGet("order/{orderId}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetOrderStatus(int id, CancellationToken token = default)
        {
            var order = await _mediator.Send(new GetOrderQuery(id), token);
            return Ok(order);
        }

        /// <summary>
        /// Cancel Order.
        /// </summary>
        /// <param name="id">Order Id</param>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpPut("cancel/{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CancelOrder(int id, CancellationToken token = default)
        {
            await _mediator.Publish(new CancelOrderCommand(id), token);
            return Ok();
        }

        /// <summary>
        /// Rate Order.
        /// </summary>
        /// <param name="id">Order Id</param>
        /// <param name="orderRate">Order Rate (range 0 to 10)</param>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpPut("order/{orderid}/rate/{orderrate}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> RateOrder(int id, int orderrate, CancellationToken token = default)
        {
            //TODO add validation
            await _mediator.Publish(new RateOrderCommand(id, orderrate), token);
            return Ok();
        }
    }
}
