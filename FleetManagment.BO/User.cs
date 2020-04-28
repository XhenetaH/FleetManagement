using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagment.BO
{
    public class User:BaseObject
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public int EmployeeID { get; set; }
        public bool IsActive { get; set; }
        public virtual Role Role { get; set; }
    }
}
