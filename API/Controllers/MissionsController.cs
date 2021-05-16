using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Missions;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MissionsController : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<Mission>>> GetMissions(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new ListMissions.Query(), cancellationToken);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Mission>> GetMission(Guid id)
        {
            return await Mediator.Send(new DetailsMission.Query{ Id = id });
        }
    }
}