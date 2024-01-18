using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoreDom.Data.Entities
{
    public class Chats
    {
        public Guid ID { get; set; } = Guid.NewGuid();

        public string SenderID { get; set; } = null!;

        [ForeignKey(nameof(SenderID))]
        public virtual User SenderUser { get; set; } = null!;

        public string ReceiverID { get; set; } = null!;

        [ForeignKey(nameof(ReceiverID))]
        public virtual User ReceiverUser { get; set; } = null!;

        public string Message { get; set; } = null!;

        public DateTime Date { get; set; } = DateTime.Now;

        public bool IsRead { get; set; } = false;

        public bool IsDeleted { get; set; } = false;
    }
}
