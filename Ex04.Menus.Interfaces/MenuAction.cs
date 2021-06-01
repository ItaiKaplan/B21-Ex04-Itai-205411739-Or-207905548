using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuAction : MenuItem
    {
        private IRunnable m_Action;

        public MenuAction (string i_Title, SubMenu i_Father, IRunnable i_Action) : base(i_Title, i_Father)
        {
            this.m_Action = i_Action;
        }
        public void OnSelected()
        {
            this.m_Action.Run();
            this.Father.OnSelected();
        }
    }
}
