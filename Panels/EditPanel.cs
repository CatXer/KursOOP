using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursOOP
{
    public partial class EditPanel : Form, IContentPanel
    {
        private Control.ControlCollection root;
        public EditPanel(RootForm form, Control.ControlCollection root)
        {
            InitializeComponent();
            this.root = root;
        }

        public void Attach()
        {
            root.Add(MainPanel);
        }

        public void Dettach()
        {
            root.Remove(MainPanel);
        }

        public Control GetMainPanel()
        {
            return MainPanel;
        }
    }
}
