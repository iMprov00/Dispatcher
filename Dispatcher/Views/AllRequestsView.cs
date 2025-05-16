using Dispatcher.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatcher.Views
{
    public partial class AllRequestsView : Form
    {
        public AllRequestsView()
        {
            InitializeComponent();
            dataGridViewRequests.DataSource = RequestsController.GetRequests();
            comboBoxStatus.DataSource = RequestsController.GetAllStatus();
            comboBoxStatus.DisplayMember = "Name";
            comboBoxStatus.ValueMember = "ID";
            EventAggregator.RequestDataChanged += RefreshDataGrid;
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dataGridViewRequests.DataSource = RequestsController.GetRequests();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxSort.Checked)
            {
                dataGridViewRequests.DataSource = RequestsController.GetRequestsForStatus((int)comboBoxStatus.SelectedValue);
                dataGridViewRequests.Columns[dataGridViewRequests.ColumnCount - 1].Visible = false;
            }
        }

        private void checkBoxSort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewRequests.Rows[e.RowIndex];
            if (row?.Cells[0]?.Value != null)
            {
                RequestView view = new RequestView((int)row.Cells[0].Value);
                view.TopLevel = false;
                view.AutoScroll = true;

                Panel parentPanel = (Panel)this.Parent;
                parentPanel.Controls.Add(view);

                // Центрируем при открытии
                CenterFormInPanel(view, parentPanel);

                // Центрируем при изменении размера панели
                parentPanel.Resize += (s, args) => CenterFormInPanel(view, parentPanel);

                view.BringToFront();
                view.Show();

            }

        }

        private void CenterFormInPanel(Form form, Panel panel)
        {
            int x = (panel.Width - form.Width) / 2;
            int y = (panel.Height - form.Height) / 2;
            form.Location = new Point(x, y);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
//__________________________________________________________________________

        private void AllRequestsView_Load(object sender, EventArgs e)
        {
         //   panel1.Dock = DockStyle.None; // Уберите DockStyle.Top
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Height = 50;
            panel1.Location = new Point(0, 0); // В верхней части контейнера
            dataGridViewRequests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRequests.Location = new Point(0, panel1.Height); // Смещение на высоту панели
            dataGridViewRequests.Size = new Size(Width, Height - panel1.Height);


            dataGridViewRequests.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewRequests.AutoResizeColumns();

            dataGridViewRequests.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewRequests.AutoResizeRows(
                    DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

        }

        private void AllRequestsView_Resize(object sender, EventArgs e)
        {
            dataGridViewRequests.Size = new Size(
                ClientSize.Width,
                ClientSize.Height - panel1.Height
            );
            dataGridViewRequests.Location = new Point(0, panel1.Height);
        }
    
    //__________________________________________________________________________
    private void dataGridViewRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            RequestView view = new RequestView();
            view.TopLevel = false;
            view.AutoScroll = true;

            // Получаем родительскую панель
            Panel parentPanel = (Panel)this.Parent;

            // Устанавливаем размер формы (можно задать фиксированный или % от панели)
            view.Width = 800;  // или (int)(parentPanel.Width * 0.8)
            view.Height = 600; // или (int)(parentPanel.Height * 0.8)

            // Вычисляем центр панели
            int x = (parentPanel.Width - view.Width) / 2;
            int y = (parentPanel.Height - view.Height) / 2;

            // Применяем позицию
            view.Location = new Point(x, y);

            // Добавляем и показываем
            parentPanel.Controls.Add(view);
            view.BringToFront();
            view.Show();
        }

        private void checkBoxSort_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (!checkBoxSort.Checked)
            {
                dataGridViewRequests.DataSource = RequestsController.GetRequests();
            }
            else
            {
                dataGridViewRequests.DataSource = RequestsController.GetRequestsForStatus((int)comboBoxStatus.SelectedValue);
                dataGridViewRequests.Columns[dataGridViewRequests.ColumnCount - 1].Visible = false;
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            dataGridViewRequests.DataSource = RequestsController.GetRequestsForStatus((int)comboBoxStatus.SelectedValue);
            dataGridViewRequests.Columns[dataGridViewRequests.ColumnCount - 1].Visible = false;
        }

        private void comboBoxStatus_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (checkBoxSort.Checked)
            {
                dataGridViewRequests.DataSource = RequestsController.GetRequestsForStatus((int)comboBoxStatus.SelectedValue);
                dataGridViewRequests.Columns[dataGridViewRequests.ColumnCount - 1].Visible = false;
            }
        }
    }
}
