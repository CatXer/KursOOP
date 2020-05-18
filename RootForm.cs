using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KursOOP
{

    public partial class RootForm : Form
    {
        private enum Panels
        {
            info,
            edit,
            insert
        }

        private IDictionary<Panels, IContentPanel> panels;
        private IContentPanel active;



        public RootForm()
        {
            InitializeComponent();
            panels = new Dictionary<Panels, IContentPanel>()
            {
                {Panels.info, new InfoPanel(this, ContentPanel.Controls)},
                {Panels.edit, new EditPanel(this, ContentPanel.Controls)},
                {Panels.insert, new InsertPanel(this, ContentPanel.Controls)}

            };
        }

        internal void UpdateUI()
        {
            MainList.Items.Clear();
            EntityManager manager = EntityManager.GetInstance();
            for (int i = 0; i < manager.GetLength(); i++)
            {
                Figure figure = manager.Get(i);
                MainList.Items.Add(i + ":    " + ((figure is null) ? ("-") : ("+    " + figure.getName())));
            }
            MainList.SetSelected(0, true);
        }

        private void Navigate(Panels type)
        {
            if (active != null && ContentPanel.Controls.Contains(active.GetMainPanel()))
            {
                active.Dettach();
            }
            active = panels[type];
            active.Attach();
        }

        private void BtCreateArray_Click(object sender, EventArgs e)
        {
            try//если нет ошибок конвертации
            {
                if (!InpItemCount.Text.Equals(""))
                {
                    EntityManager.GetInstance(Convert.ToInt32(InpItemCount.Text)).GetLength();

                    InpItemCount.Enabled = false;
                    BtCreateArray.Enabled = false;
                    BtArrayInfo.Enabled = true;
                    InpIndex.Enabled = true;
                    UpdateUI();
                }
                else
                {
                    MessageBox.Show("Вы не ввели длину массива..", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)//иначе ошибка
            {
                MessageBox.Show("Длинна должна быть только из одного числа [0-9]!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtArrayInfo_Click(object sender, EventArgs e)
        {
            /*
             * 4.	В каждый момент времени, по запросу, программа должна сообщать, 
             * сколько и каких элементов уже помещено в массив, 
             * сколько свободных мест осталось.
             */
        }

        private void BtShowInfo_Click(object sender, EventArgs e)
        {
            Navigate(Panels.info);
        }

        private void BtChangeObject_Click(object sender, EventArgs e)
        {
            Navigate(Panels.edit);
        }

        private void BtAddObject_Click(object sender, EventArgs e)
        {
            Navigate(Panels.insert);
        }

        private void MainList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntityManager manager = EntityManager.GetInstance();
            manager.SetSelectedIndex(MainList.SelectedIndex);

            if (!manager.IsSelected())
            {
                InpIndex.Text = "";
                BtAddObject.Enabled = false;
                BtChangeObject.Enabled = false;
                BtShowInfo.Enabled = false;
            }
            else if (manager.GetSelected() is null)
            {
                InpIndex.Text = MainList.SelectedIndex.ToString();
                BtAddObject.Enabled = true;
                BtChangeObject.Enabled = false;
                BtShowInfo.Enabled = false;
            }
            else
            {
                InpIndex.Text = MainList.SelectedIndex.ToString();
                BtAddObject.Enabled = false;
                BtChangeObject.Enabled = true;
                BtShowInfo.Enabled = true;
            }

        }

        private void InpIndex_TextChanged(object sender, EventArgs e)
        {
            int index = -1;
            try//если нет ошибок конвертации
            {
                if (!InpIndex.Text.Equals(""))
                {
                    index = Convert.ToInt32(InpIndex.Text);
                    if (index < 0)
                    {
                        throw new FormatException();
                    }
                    else if (index >= MainList.Items.Count)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        MainList.SetSelected(index, true);
                    }
                }
                else
                {
                    MainList.ClearSelected();
                }
            }
            catch (FormatException)//иначе ошибка
            {
                MainList.ClearSelected();
                MessageBox.Show("Допускается вводить только натуральные числа или 0!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InpIndex.Text = "";
            }
            catch (IndexOutOfRangeException)
            {
                MainList.ClearSelected();
                MessageBox.Show("Элемента с индексом = [" + index.ToString() + "] не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InpIndex.Text = "";
            }
        }
    }
}
