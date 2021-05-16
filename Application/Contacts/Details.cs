using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistense;

namespace Application.Contacts
{
    public class DetailsContact
    {
        public class Query : IRequest<Contact>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Contact>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Contact> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Contacts.FindAsync(request.Id);
            }
        }
    }
}