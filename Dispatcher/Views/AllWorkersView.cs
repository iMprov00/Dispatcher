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
    public partial class AllWorkersView : Form
    {
        public AllWorkersView()
        {
            InitializeComponent();
           // panel1.Dock = DockStyle.Top; // Уберите DockStyle.Top
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Height = 50;
            panel1.Location = new Point(0, 0); // В верхней части контейнера
            dataGridViewWorkers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewWorkers.Location = new Point(0, panel1.Height); // Смещение на высоту панели
            dataGridViewWorkers.Size = new Size(Width, Height - panel1.Height);


            dataGridViewWorkers.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewWorkers.AutoResizeColumns();

            dataGridViewWorkers.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewWorkers.AutoResizeRows(
                    DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            dataGridViewWorkers.DataSource = WorkerController.GetAllWorkersInfoForDataGrid();

            EventAggregator.RequestDataChanged += RefreshDataGrid;
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dataGridViewWorkers.DataSource = RequestsController.GetRequests();
        }

        private void AllWorkersView_Resize(object sender, EventArgs e)
        {
            dataGridViewWorkers.Size = new Size(
                ClientSize.Width,
                ClientSize.Height - panel1.Height
            );
            dataGridViewWorkers.Location = new Point(0, panel1.Height);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefill_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewWorkers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewWorkers.Rows[e.RowIndex];
            if (row != null)
            {
                WorkerView view = new WorkerView((int)row.Cells[0].Value);
                view.TopLevel = false;
                view.AutoScroll = true;
                view.TopMost = true;
                ((Panel)this.Parent).Controls.Add(view);
                view.Show();
            }
        }

        private void AllRequestsView_Load(object sender, EventArgs e)
        {


        }


        private void AllWorkersView_Load(object sender, EventArgs e)
        {

        }

        private void buttonRefill_Click_1(object sender, EventArgs e)
        {
            dataGridViewWorkers.DataSource = WorkerController.GetAllWorkersInfoForDataGrid();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            WorkerView view = new WorkerView();
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

            ((Panel)this.Parent).Controls.Add(view);
            view.BringToFront();
            view.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewWorkers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
