using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLProject.Services
{
    public class SubMenuService : ISubMenu
    {

        private GraphQLDbContext _dbcontext;

        public SubMenuService(GraphQLDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public SubMenu AddSubMenu(SubMenu subMenu)
        {
            _dbcontext.SubMenu.Add(subMenu);
            _dbcontext.SaveChanges();
            return subMenu;
        }

        public List<SubMenu> GetSubMenus()
        {
            return _dbcontext.SubMenu.ToList();
        }

        public List<SubMenu> GetSubMenus(int menuId)
        {
            var retorno = _dbcontext.SubMenu.Where(a => a.MenuId == menuId).ToList();
            return retorno;
        }

    }
}
