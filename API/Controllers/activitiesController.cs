using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Domain;


namespace API.Controllers
{
    public class activitiesController : baseAPIController
    {
        private readonly DataContext _context;
        public activitiesController(DataContext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities(){
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id){
            return await _context.Activities.FindAsync(id);
        }

    }
}