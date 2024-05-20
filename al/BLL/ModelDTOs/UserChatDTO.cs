using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelDTOs
{
    public class UserChatDTO : UserDTO
    {
        public List<ChatDto> chats { get; set; }
        public UserChatDTO()
        {
            chats = new List<ChatDto>();
        }
    }
}
