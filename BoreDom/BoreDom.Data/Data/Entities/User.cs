using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoreDom.Data.Entities
{
    public class User:IdentityUser
    {
        public Guid PictureID { get; set; }

        [ForeignKey(nameof(PictureID))]
        public ProfilePicture Picture { get; set; } = null!;

        public ICollection<Post> UserPosts {get;set;} = new List<Post>();
        public ICollection<Like> Likes {get;set;} = new List<Like>();

        public ICollection<Follower> Followers { get; set; } = new List<Follower>();
        public ICollection<Follower> Followed { get; set; } = new List<Follower>();
        public ICollection<Blocks> Blocked { get; set; } = new List<Blocks>();
        public ICollection<Chats> Chats { get; set; } = new List<Chats>();
    }
}
