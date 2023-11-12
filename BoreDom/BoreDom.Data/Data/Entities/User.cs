using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoreDom.Data.Entities
{
    public class User:IdentityUser
    {
        public Guid PictureID { get; set; }

        [ForeignKey(nameof(PictureID))]
        public ProfilePicture Picture { get; set; } = null!;
    }
}
