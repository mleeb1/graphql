using System.Collections.Generic;
using System.Threading.Tasks;
using CarvedRock.Api.Data;
using CarvedRock.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarvedRock.Api.Repositories
{
    public class OwnerRepository
    {
        private readonly CarvedRockDbContext _dbContext;

        public OwnerRepository(CarvedRockDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Owner>> GetAll()
        {
            return await _dbContext.Owners.ToListAsync();
        }
    }
}
