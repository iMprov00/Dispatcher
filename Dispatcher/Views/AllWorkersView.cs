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
            dataGridViewWorkers.DataSource = WorkerController.GetAllWorkersInfoForDataGrid();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            WorkerView view = new WorkerView();
            view.TopLevel = false;
            view.AutoScroll = true;
            view.TopMost = true;
            ((Panel)this.Parent).Controls.Add(view);
            view.BringToFront();
            view.Show();
        }

        private void buttonRefill_Click(object sender, EventArgs e)
        {
            dataGridViewWorkers.DataSource = WorkerController.GetAllWorkersInfoForDataGrid();
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

        private void AllWorkersView_Load(object sender, EventArgs e)
        {

        }
    }
}
