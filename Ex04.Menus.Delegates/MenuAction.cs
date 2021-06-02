using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuAction : MenuItem
    {
        public event Action m_Action;
        //private IRunnable m_Action;

        public MenuAction(string i_Title, Action i_Action) : base(i_Title)
        {
            this.m_Action += i_Action;
        }

        public override void RunItem()
        {
            this.m_Action?.Invoke(); 
        }

        public override void OnSelected()
        {
            this.RunItem();
            this.Father.OnSelected();
        }
    }
}
