using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Domain.Infrastructure.Handler.Order.Queries.GetOrderList
{
    public class GetOrdersListQuery : IRequest<IEnumerable<DDDExample.Infrastructure.Entities.Order>>
    {
    }
}
