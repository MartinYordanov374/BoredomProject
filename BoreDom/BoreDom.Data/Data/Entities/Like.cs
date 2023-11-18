using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoreDom.Data.Entities
{
    public class Like
    {
        // LikeID
        [Key]
        public Guid LikeID {get;set;} = Guid.NewGuid();
        // LikerID
        public string LikerID {get;set;} = null!;
        public User User {get;set;} = null!;
        // PostID
        
        public Guid PostID {get;set;}

        [ForeignKey(nameof(PostID))]
        public Post Post {get;set;}
        
    }
}
