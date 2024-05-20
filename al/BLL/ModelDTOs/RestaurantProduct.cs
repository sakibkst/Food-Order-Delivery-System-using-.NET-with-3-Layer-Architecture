using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelDTOs
{
    public class RestaurantProductDTO : RestaurantDTO
    {
        public List<ProductDTO> products { get; set; }
        public RestaurantProductDTO()
        {
            products = new List<ProductDTO>();
        }
    }
}
