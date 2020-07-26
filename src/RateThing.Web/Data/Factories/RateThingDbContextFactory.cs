using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RateThing.Web.Data
{
    public class RateThingDbContextFactory : IDesignTimeDbContextFactory<RateThingDbContext>
    {
        public RateThingDbContext CreateDbContext(string[] args) => new RateThingDbContext("Host=localhost;Port=26875;Username=framething;Password=topsecret");
    }
}
