using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoreDom.Data.Entities
{
    public class Blocks
    {
        public string BlockerID { get; set; } = null!;

        [ForeignKey(nameof(BlockerID))]
        public virtual User BlockerUser { get; set; } = null!;
        public string BlockedID { get; set; } = null!;

        [ForeignKey(nameof(BlockedID))]
        public virtual User BlockedUser { get; set; } = null!;
    }
}
