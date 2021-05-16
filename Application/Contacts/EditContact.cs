using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistense;

namespace Application.Contacts
{
    public class EditContact
    {
        public class Command : IRequest
        {
            public Contact Contact { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var contact = await _context.Contacts.FindAsync(request.Contact.Id);

                _mapper.Map(request.Contact, contact);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}