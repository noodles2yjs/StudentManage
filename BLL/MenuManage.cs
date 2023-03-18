using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MenuManage
    {
        private MenuService service = new MenuService();

        public List<Menu> GetAllMeus()
        {
            return service.GetAllMeus();
        }
    }
}
