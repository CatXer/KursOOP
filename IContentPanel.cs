using System.Windows.Forms;

namespace KursOOP
{
    public interface IContentPanel
    {
        

        void Attach();
        void Dettach();
        Control GetMainPanel();
    }
}
