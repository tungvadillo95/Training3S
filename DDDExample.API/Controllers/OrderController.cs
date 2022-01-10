using DDDExample.Domain.Infrastructure.Handler.Order.Commands;
using DDDExample.Domain.Infrastructure.Handler.Order.Queries.GetOrder;
using DDDExample.Domain.Infrastructure.Handler.Order.Queries.GetOrderByUserId;
using DDDExample.Domain.Infrastructure.Handler.Order.Queries.GetOrderList;
using DDDExample.Infrastructure.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDExample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET api/order/id
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Guid guidId;
            if (!Guid.TryParse(id, out guidId)) return Ok(null);
            return Ok(await _mediator.Send(new GetOrderQuery { Id = guidId }));
        }
        // GET api/order/userId
        [HttpGet("getByUserId/{userId}")]
        public async Task<IActionResult> GetByUserId(string userId)
        {
            Guid guidId;
            if (!Guid.TryParse(userId, out guidId)) return Ok(null);
            return Ok(await _mediator.Send(new GetOrdersByUserIdQuery { UserId = guidId }));
        }
        // GET api/order
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetAll()
        {
            return Ok(await _mediator.Send(new GetOrdersListQuery()));
        }
        // POST api/order
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateOrderCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
