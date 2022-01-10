using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Domain.Infrastructure.Handler.Order.Queries.GetOrder
{
    public class GetOrderQuery : IRequest<DDDExample.Infrastructure.Entities.Order>
    {
        public Guid Id { get; set; }
    }
}
