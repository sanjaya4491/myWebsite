using Microsoft.EntityFrameworkCore;
using myFirstProject.Models;
using System.Collections.Generic;
using System;
using myFirstProject.Data;
using myFirstProject.Data.Base;

namespace myFirstProject.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context)
        {
        }
    }
}
