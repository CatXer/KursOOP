using System.Windows.Forms;

namespace KursOOP
{
    public interface IContentPanel
    // Описание интерфейса, предназначенного для реализации взаимодействия с панелями из других Frame
    {
        // Метод прикрепления контента фрейма (Controil) к родительскому ControlCollection
        void Attach();
        // Метод открепления..
        void Dettach();
        // Метод получения контента фрейма (Controil)
        Control GetMainPanel();
    }
}
