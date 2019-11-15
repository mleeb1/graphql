using System.Collections.Generic;
using System.Linq;
using CarvedRock.Api.Data.Entities;

namespace CarvedRock.Api.Data
{
    public static class InitialData
    {
        public static void Seed(this CarvedRockDbContext dbContext)
        {
            if (!dbContext.Policies.Any())
            {
                dbContext.Owners.AddRange(new List<Owner>
                {
                    new Owner
                    {
                        Name = "Owner 1"
                    },
                    new Owner
                    {
                        Name = "Owner 2"
                    },
                    new Owner
                    {
                        Name = "Owner 3"
                    },
                    new Owner
                    {
                        Name = "Owner 4"
                    }
                });

                dbContext.Policies.Add(new Policy
                {
                    Name = "My Policy 1",
                    Type = PolicyTypeEnum.WholeLife,
                    OwnerId = 1
                });

                dbContext.Policies.Add(new Policy
                {
                    Name = "My Policy 2",
                    Type = PolicyTypeEnum.Annuity,
                    OwnerId = 1
                });

                dbContext.Policies.Add(new Policy
                {
                    Name = "My Policy 3",
                    Type = PolicyTypeEnum.WholeLife,
                    OwnerId = 2
                });

                dbContext.Policies.Add(new Policy
                {
                    Name = "My Policy 4",
                    Type = PolicyTypeEnum.Annuity,
                    OwnerId = 2
                });

                dbContext.Policies.Add(new Policy
                {
                    Name = "My Policy 5",
                    Type = PolicyTypeEnum.WholeLife,
                    OwnerId = 3
                });

                dbContext.Policies.Add(new Policy
                {
                    Name = "My Policy 6",
                    Type = PolicyTypeEnum.Annuity,
                    OwnerId = 4
                });

                dbContext.SaveChanges();
            }
        }
    }
}
