using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistense;

namespace API.Controllers
{
    public class MissionsController : BaseApiController
    {
        private readonly DataContext _context;
        public MissionsController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<List<Mission>>> GetMissions()
        {
            return await _context.Missions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Mission>> GetMission(Guid id)
        {
            return await _context.Missions.FindAsync(id);
        }
    }
}