using DDDExample.Domain.DTOs.Respone.User;
using DDDExample.Domain.Infrastructure.Handler.User.Commands.CreateUser;
using DDDExample.Domain.Infrastructure.Handler.User.Queries.GetUserDetail;
using DDDExample.Domain.Infrastructure.Handler.User.Queries.GetUsersList;
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
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET api/user/id
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _mediator.Send(new GetUserDetailQuery { Id = id }));
        }
        // GET api/user
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDetail>>> GetAll()
        {
            return Ok(await _mediator.Send(new GetUsersListQuery()));
        }
        // POST api/user
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
