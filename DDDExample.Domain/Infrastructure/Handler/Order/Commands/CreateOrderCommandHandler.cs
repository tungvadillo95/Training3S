using AutoMapper;
using DDDExample.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDDExample.Domain.Infrastructure.Handler.Order.Commands
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, string>
    {
        private readonly IDDDExampleDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IDDDExampleDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<string> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var order = _mapper.Map<DDDExample.Infrastructure.Entities.Order>(request);
                if (order != null)
                {
                    await _dbContext.Orders.AddAsync(order);
                    if (await _dbContext.SaveChangesAsync() > 0)
                    {
                        return order.Id.ToString();
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
