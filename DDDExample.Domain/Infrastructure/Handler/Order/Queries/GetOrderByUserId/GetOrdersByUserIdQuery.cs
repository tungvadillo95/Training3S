using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Domain.Infrastructure.Handler.Order.Queries.GetOrderByUserId
{
    public class GetOrdersByUserIdQuery : IRequest<IEnumerable<DDDExample.Infrastructure.Entities.Order>>
    {
        public Guid UserId { get; set; }
    }
}
