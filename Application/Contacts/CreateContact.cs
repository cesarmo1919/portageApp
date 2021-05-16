using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistense;

namespace Application.Contacts
{
    public class CreateContact
    {
        public class Command : IRequest
        {
            public Contact Contact { get; set; }
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
                _context.Contacts.Add(request.Contact);
                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}