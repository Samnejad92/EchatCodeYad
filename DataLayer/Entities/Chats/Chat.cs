using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Chats
{
    class Chat:BaseEntity
    {
        public string ChatBody { get; set; }
        public long UserId { get; set; }
    }
}
