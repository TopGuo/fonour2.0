using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fonor2._0.domain.Entitys
{
    public class RoleMenu
    {
        public Guid RoleId { get; set; }
        public Role Role { get; set; }

        public Guid MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
