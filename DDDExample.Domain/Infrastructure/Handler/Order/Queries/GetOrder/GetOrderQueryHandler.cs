using AutoMapper;
using DDDExample.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDDExample.Domain.Infrastructure.Handler.Order.Queries.GetOrder
{
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, DDDExample.Infrastructure.Entities.Order>
    {
        private readonly IDDDExampleDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetOrderQueryHandler(IDDDExampleDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<DDDExample.Infrastructure.Entities.Order> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders.Where(o => o.Id == request.Id)
                                                .Include(o => o.User).ThenInclude(u => u.Role)
                                                .AsNoTracking()
                                             .Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                                             .FirstOrDefaultAsync();
            if (order != null) return order;
            return new DDDExample.Infrastructure.Entities.Order();
        }
    }
}
