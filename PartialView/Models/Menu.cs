using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialView.Models
{
    public class Menu
    {
        public string MenuId { get; set; }
        public string MenuDescription { get; set; }

        public static List<Menu> GetMenus()
        {
            List<Menu> menus = new List<Menu>();

            for (int i = 0; i < 5; i++)
            {
                menus.Add(new Menu() { MenuId=i.ToString(),
                                        MenuDescription="Menu - " + i.ToString()});
            }
            return menus;
        }
    }
    

}