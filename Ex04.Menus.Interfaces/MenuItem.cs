using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_Title;

        protected MenuItem(string i_Title)
        {
            this.m_Title = i_Title;
        }

        public string Title
        {
            get { return m_Title; }
        }
    }
}
