using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardCore
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string AddedUser { get; set; }
        public string ModifiedUser { get; set; }
        public string IP { get; set; }
    }
}
