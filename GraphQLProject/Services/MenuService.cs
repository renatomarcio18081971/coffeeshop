using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLProject.Services
{
    public class MenuService : IMenu
    {
        private GraphQLDbContext _dbcontext;

        public MenuService(GraphQLDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Menu AddMenu(Menu menu)
        {
            _dbcontext.Menu.Add(menu);
            _dbcontext.SaveChanges();
            return menu;
        }

        public List<Menu> GetMenus()
        {
            return _dbcontext.Menu.ToList();
        }
    }
}
