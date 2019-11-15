using System.ComponentModel.DataAnnotations;

namespace CarvedRock.Api.Data.Entities
{
    public class Policy
    {
        public int Id { get; set; }

        [StringLength(100), Required]
        public string Name { get; set; }

        public PolicyTypeEnum Type { get; set; }

        public int OwnerId { get; set; }
    }
}
