using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoreDom.Data.Entities
{
    public class Follower
    {
        public string FollowerID { get; set; } = null!;
        public virtual User FollowerUser { get; set; } = null!;
        public string FollowedID { get; set; } = null!;
        public virtual User FollowedUser { get; set; } = null!;

    }
}
