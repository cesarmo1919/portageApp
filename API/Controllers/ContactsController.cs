using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Contacts;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ContactsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Contact>>> GetContacts(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new ListContacts.Query(), cancellationToken);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContact(Guid id)
        {
            return await Mediator.Send(new DetailsContact.Query{ Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(Contact contact)
        {
            return Ok(await Mediator.Send(new CreateContact.Command { Contact = contact }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditContact(Guid id, Contact contact)
        {
            contact.Id = id;
            
            return Ok(await Mediator.Send(new EditContact.Command { Contact = contact }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(Guid id)
        {
            return Ok(await Mediator.Send(new DeleteContact.Command { Id = id }));
        }
    }
}