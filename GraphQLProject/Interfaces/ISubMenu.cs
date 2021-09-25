﻿using GraphQLProject.Data;
using System.Collections.Generic;

namespace GraphQLProject.Interfaces
{
    public interface ISubMenu
    {
        List<SubMenu> GetSubMenus();
        List<SubMenu> GetSubMenus(int menuId);
        SubMenu AddSubMenu(SubMenu menu);
    }
}
