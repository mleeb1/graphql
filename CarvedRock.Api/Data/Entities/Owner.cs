using System.ComponentModel.DataAnnotations;
namespace CarvedRock.Api.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [StringLength(200), Required]
        public string Name { get; set; }
    }
}
