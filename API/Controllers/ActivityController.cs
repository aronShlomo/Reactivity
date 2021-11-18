using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivityController : BaseApiController
    {
        private readonly DataContext context;
        public ActivityController(DataContext context)
        {
            this.context = context;

        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities(){
            return await context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivities(Guid id){
            return await context.Activities.FindAsync(id);
        }

    }
}