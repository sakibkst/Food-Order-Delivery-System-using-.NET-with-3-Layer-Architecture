using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelDTOs
{
    public class DeliverymanDTO
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Username { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        public string DeliveryManStatus { get; set; }

        public string MobileNumber { get; set; }


        [ForeignKey("DeliverymanTypeDTO")]

        public int dtId { get; set; }
        public virtual DeliverymanTypeDTO DeliverymanTypeDTO { get; set; }

    }
}

