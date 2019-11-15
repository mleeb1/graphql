using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarvedRock.Api.Data;
using CarvedRock.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarvedRock.Api.Repositories
{
    public class PolicyRepository
    {
        private readonly CarvedRockDbContext _dbContext;

        public PolicyRepository(CarvedRockDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Policy>> GetForOwner(int ownerId)
        {
            return await _dbContext.Policies.Where(p => p.OwnerId == ownerId).ToListAsync();
        }
    }
}
