using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelDTOs
{
    public class DeliveryManDeliveryLogDTO : DeliverymanDTO
    {
        public List<DeliveryLogDTO> DeliveryLogs { get; set; }
        public DeliveryManDeliveryLogDTO()
        {
            DeliveryLogs = new List<DeliveryLogDTO>();
        }
    }
}

