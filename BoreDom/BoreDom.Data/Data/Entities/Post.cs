using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoreDom.Data.Entities
{
    public class Post
    {
        [Key]
        public Guid ID { get; set; } = Guid.NewGuid();

        public string PosterID { get; set; } = null!;

        [ForeignKey(nameof(PosterID))]
        public User User { get; set; } = null!;

        public Guid? ParentID { get;set; }

        [ForeignKey(nameof(ParentID))]
        public Post Parent { get; set; }

        public string Content {get;set;} = null!;

        public ICollection<Like> Likes {get;set;} = new List<Like>();
        public ICollection<Shares> Shares { get;set; } = new List<Shares>();
    }
}
