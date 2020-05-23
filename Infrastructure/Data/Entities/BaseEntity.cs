using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Entities
{
   public class BaseEntity
    {
        public DateTime ModifiedOn { get; set; }
        public DateTime CreatedOn { get; set; }

        public int  ModifiedBy{ get; set; }

        public int CreatedBy{ get; set; }
    }
}
