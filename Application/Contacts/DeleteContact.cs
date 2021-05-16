using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistense;

namespace Application.Contacts
{
    public class DeleteContact
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var contact = await _context.Contacts.FindAsync(request.Id);

                _context.Remove(contact);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}