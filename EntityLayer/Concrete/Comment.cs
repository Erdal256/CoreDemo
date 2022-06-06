using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Comment
    {
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommnetTitle { get; set; }
        public string CommnetContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommnentStatus { get; set; }
    }
}
