using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Entities
{
   public class ApplicationRole:BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string NormalizedName { get; set; }
    }
}
