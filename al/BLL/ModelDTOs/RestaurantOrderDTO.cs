using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelDTOs
{
    public class RestaurantOrderDTO : RestaurantDTO
    {
        public List<OrderDTO> orders { get; set; }
        public RestaurantOrderDTO()
        {
            orders = new List<OrderDTO>();
        }
    }
}
