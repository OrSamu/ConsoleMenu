namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private string m_Title;
        private readonly Menu r_PreviousMenu;

        protected MenuItem(string i_Title, Menu i_PreviousMenu)
        {
            m_Title = i_Title;
            r_PreviousMenu = i_PreviousMenu;
        }

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public MenuItem PreviousMenu
        {
            get
            { return r_PreviousMenu; }
        }

        internal abstract void Activate();
    }
}