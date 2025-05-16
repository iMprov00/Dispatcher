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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы действительно хотите выйти?", "Предупреждение",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CloseAllChildForms()
        {
            // Создаем копию коллекции, так как исходная будет меняться
            var controlsToRemove = panelBase.Controls.OfType<Form>().ToList();

            foreach (var form in controlsToRemove)
            {
                form.Close();
                form.Dispose();
            }
            panelBase.Controls.Clear();
        }
        private void buttonRequest_Click(object sender, EventArgs e)
        {
            CloseAllChildForms(); // Закрываем все предыдущие формы

            AllRequestsView viewReq = new AllRequestsView();
            OpenFormWithAnimation(viewReq);
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            CloseAllChildForms(); // Закрываем все предыдущие формы

            AdminView viewAdm = new AdminView();
            OpenFormWithAnimation(viewAdm);
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            AllWorkersView view = new AllWorkersView();
            OpenFormWithAnimation(view);


        }

        private void OpenFormWithAnimation(Form form)
        {
            // Начальные настройки
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill; // Или другой Dock

            // Начальный размер (например, 10% от целевого)
            form.Size = new Size(
                (int)(panelBase.Width * 0.1),
                (int)(panelBase.Height * 0.1)
            );

            // Центрируем
            form.Location = new Point(
                (panelBase.Width - form.Width) / 2,
                (panelBase.Height - form.Height) / 2
            );

            panelBase.Controls.Add(form);
            form.Show();
        }
    }
}
