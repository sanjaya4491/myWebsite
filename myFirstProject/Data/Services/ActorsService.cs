using Microsoft.EntityFrameworkCore;
using myFirstProject.Models;
using System.Collections.Generic;
using System;
using myFirstProject.Data;
using myFirstProject.Data.Base;

namespace myFirstProject.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorService(AppDbContext context) : base(context)
        {
        }
    }
}
