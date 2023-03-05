using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SysAdminManage
    {
        private SysAdminService service= new SysAdminService();
        public SysAdmin AdminLogin(SysAdmin admin)
        {
            return service.AdminLogin(admin);
        }

        public int ModifyPwd(SysAdmin sysAdmin)
        {
            return service.ModifyPwd(sysAdmin);
        }
    }
}
