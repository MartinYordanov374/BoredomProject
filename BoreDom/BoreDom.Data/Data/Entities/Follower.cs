using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoreDom.Data.Entities
{
    public class Follower
    {
       public string? FollowerID {get;set;}
       [ForeignKey(nameof(FollowerID))]
        public User Followers {get;set;} = null!;

       public string? FollowedID {get;set;}
       [ForeignKey(nameof(FollowedID))]
       public User ReverseFollowers {get;set;} = null!;
       

    }
}
