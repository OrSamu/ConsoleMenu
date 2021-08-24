namespace Ex04.Menus.Delegates
{
    public delegate void ActionSelectedEventHandler();

    public class ActionItem : MenuItem
    {
        public event ActionSelectedEventHandler ActionSelected;

        public ActionItem(string i_Title, Menu i_PreviousItem)
            : base(i_Title, i_PreviousItem)
        {
        }

        internal override void DoWhenMenuItemSelected()
        {
            OnExecuteAction();
        }

        protected virtual void OnExecuteAction()
        {
            if (ActionSelected != null)
            {
                ActionSelected.Invoke();
            }
            PreviousMenuItem.DoWhenMenuItemSelected();
        }

    }
}