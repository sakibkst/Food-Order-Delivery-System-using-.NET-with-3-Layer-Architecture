using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelDTOs
{
    public class OrderUserDTO:UserDTO
    {
        public List<OrderDTO> orders { get; set; }
        public OrderUserDTO()
        {
            orders = new List<OrderDTO>();
        }
    }
}
