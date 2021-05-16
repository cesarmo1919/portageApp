using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistense;

namespace Application.Missions
{
    public class DetailsMission
    {
        public class Query : IRequest<Mission>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Mission>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;

            }

            public async Task<Mission> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Missions.FindAsync(request.Id);
            }
        }
    }
}