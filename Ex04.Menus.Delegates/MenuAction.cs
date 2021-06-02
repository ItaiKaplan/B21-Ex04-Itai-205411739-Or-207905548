using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuAction : MenuItem
    {
        private IRunnable m_Action;

        public MenuAction(string i_Title, IRunnable i_Action) : base(i_Title)
        {
            this.m_Action = i_Action;
        }

        public override void RunItem()
        {
            this.m_Action.Run();
        }

        public override void OnSelected()
        {
            this.RunItem();
            this.Father.OnSelected();
        }
    }
}
