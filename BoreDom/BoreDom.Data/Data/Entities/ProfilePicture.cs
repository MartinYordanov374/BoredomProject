using System.ComponentModel.DataAnnotations;

namespace BoreDom.Data.Entities
{
    public class ProfilePicture
    {
        [Key]
        public Guid ID { get; set; } = Guid.NewGuid();

        [Required]
        public byte[] Picture { get; set; } = null!;
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
