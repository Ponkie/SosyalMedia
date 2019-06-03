using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Data
{
    class Post : Entity
    {
        public int PostId { get; set; }
        public string PostContent { get; set; }
        public DateTime PostCreated { get; set; }
        
    }
}
