namespace Ex04.Menus.Delegates
{
    public delegate void MenuItemSelectedDelegate(object sender);

    public abstract class MenuItem
    {
        private string m_Title;
        public event MenuItemSelectedDelegate MenuItemSelected;

        protected MenuItem(string i_Title)
        {
            this.m_Title = i_Title;
        }

        public abstract void SelectionAction(object i_sender);
        public string Title
        {
            get { return m_Title; }
        }

        protected virtual void OnMenuItemSelect(object i_sender)
        {
            MenuItemSelected?.Invoke(i_sender);
        }
    }
}