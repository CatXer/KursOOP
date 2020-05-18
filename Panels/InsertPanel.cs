using System.Windows.Forms;

namespace KursOOP
{
    public partial class InsertPanel : Form, IContentPanel
    {
        private Control.ControlCollection root;
        private RootForm form;
        private Figure NewFigure;

        public InsertPanel(RootForm form, Control.ControlCollection root)
        {
            InitializeComponent();
            this.form = form;
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

        private void RbTriangle_CheckedChanged(object sender, System.EventArgs e)
        {
            if (RbTriangle.Checked)
            {
                BtSave.Enabled = true;

                Param1.Show();
                Param2.Show();
                InpParam1.Show();
                InpParam2.Show();

                Param1.Text = "Основание";//лейблы переименовываются под данные треугольника
                Param2.Text = "Высота";
                InpParam1.Enabled = true;
                InpParam2.Enabled = true;


                if (NewFigure is null || NewFigure.GetType() != typeof(Triangle))//если фигура не была треугольником (для избежания случайного сброса данных при втором подряд нажатии на кнопку треугольника)
                    NewFigure = new Triangle();//то создаётся треугольник без параметров
                LabelType.Text = NewFigure.getName();
                InpParam1.Text = ((Triangle)NewFigure).getBase().ToString();//и в поле заносится сторона треугольника
                InpParam2.Text = ((Triangle)NewFigure).getHeight().ToString();
            }

        }

        private void RbRhombus_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void RbCircle_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void BtSave_Click(object sender, System.EventArgs e)
        {
            EntityManager manager = EntityManager.GetInstance();

            if (!manager.IsSelected())
            {
                MessageBox.Show("Вы не выбрали элемент..", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (manager.GetSelected() != null)
            {
                MessageBox.Show("Не удалось разместить объект, ячейка занята!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                manager.InsertIntoSelected(NewFigure);
            }
            form.UpdateUI();
            Dettach();
        }

        public Control GetMainPanel()
        {
            return MainPanel;
        }
    }
}
