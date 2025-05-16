using Dispatcher.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatcher
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Program.formsContext.Add(this);
        }



/*        private void CloseAllChildForms()
        {
            // Создаем копию коллекции, так как исходная будет меняться
            var controlsToRemove = panelBase.Controls.OfType<Form>().ToList();

            foreach (var form in controlsToRemove)
            {
                form.Close();
                form.Dispose();
            }
            panelBase.Controls.Clear();
        }*/
        private void buttonRequest_Click(object sender, EventArgs e)
        {


        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {


        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {



        }

        private void OpenFormWithAnimation(Form form)
        {
            // Начальные настройки
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill; // Или другой Dock

/*            // Начальный размер (например, 10% от целевого)
            form.Size = new Size(
                (int)(panelBase.Width * 0.1),
                (int)(panelBase.Height * 0.1)
            );

            // Центрируем
            form.Location = new Point(
                (panelBase.Width - form.Width) / 2,
                (panelBase.Height - form.Height) / 2
            );*/

            panelBase.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonRequest_Click_1(object sender, EventArgs e)
        {
            AllRequestsView viewReq = new AllRequestsView();
            OpenFormWithAnimation(viewReq);
        }

        private void buttonWorkers_Click_1(object sender, EventArgs e)
        {
            AllWorkersView view = new AllWorkersView();
            OpenFormWithAnimation(view);
        }

        private void buttonAdmin_Click_1(object sender, EventArgs e)
        {
            AdminView viewAdm = new AdminView();
            OpenFormWithAnimation(viewAdm);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Authorization main = new Authorization();
                main.Show();
                this.Hide();
            }
        }
    }
}
