using Microsoft.AspNetCore.Mvc;
using System;
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
        [HttpPost("order")]
        public async Task<IActionResult> CreateOrders([FromBody] OrderRequest orderRequest, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get order details and status.
        /// </summary>
        /// <param name="id">Order Id.</param>
        /// <param name="token"></param>
        /// <returns>OrderDto</returns>
        [Route("{orderId}")]
        public async Task<IActionResult> GetOrderStatus(int id, CancellationToken token = default)
        {
            var order = await _mediator.SendAsync(new GetOrderQuery(id), token);
            return Ok(order);
        }
        [Route("cancel")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CancelOrder(string id, CancellationToken token = default)
        {
            if (!Guid.TryParse(id, out var guid) || guid != Guid.Empty)
                return BadRequest();

            await _mediator.PublishAsync(new CancelOrderCommand(guid), token);
            return Ok();
        }
    }
}
