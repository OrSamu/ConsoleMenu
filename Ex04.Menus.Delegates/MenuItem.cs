namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        protected readonly string r_Title;
        protected readonly MenuItem r_PreviousMenu;

        protected MenuItem(string i_Title,MenuItem i_PreviousMenu)
        {
            r_Title = i_Title;
            r_PreviousMenu = i_PreviousMenu;
        }

        public string Title
        {
            get { return r_Title; }
        }

        public MenuItem PreviousMenuItem
        {
            get { return r_PreviousMenu; }
        }

        internal abstract void DoWhenMenuItemSelected();
    }
}