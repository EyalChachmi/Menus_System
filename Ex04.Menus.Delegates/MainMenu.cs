using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private InnerMenu m_MainMenu;

        public MainMenu()
        {
            m_MainMenu = new InnerMenu("Main Menu");
        }

        public void ShowMainMenu()
        {
            m_MainMenu.InnerMenu_MenuItemSelected(m_MainMenu);
        }

        public void AddInternalMenu(MenuItem i_MenuChoice)
        {
            m_MainMenu.AddMenuChoice(i_MenuChoice);
        }
    }
}
