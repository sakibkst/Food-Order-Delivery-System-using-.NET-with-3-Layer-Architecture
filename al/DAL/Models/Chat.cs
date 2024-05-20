using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Chat
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int Uid { get; set; }
        [ForeignKey("Deliveryman")]
        public int DId { get; set; }
        public String Msg { get; set; }
        public virtual User User { get; set; }
        public virtual Deliveryman Deliveryman { get; set; }
    }
}
