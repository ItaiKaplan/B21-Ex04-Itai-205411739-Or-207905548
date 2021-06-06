using System;

namespace Ex04.Menus.Delegates
{
    public class MenuAction : MenuItem
    {
        public event Action ActionDelegate;

        public MenuAction(string i_Title, Action i_Action) : base(i_Title)
        {
            this.ActionDelegate += i_Action;
        }

        public override void RunItem()
        {
            this.OnSelected();
        }

        protected virtual void OnSelected()
        {
            this.ActionDelegate?.Invoke();
            this.Father.RunItem();
        }
    }
}
