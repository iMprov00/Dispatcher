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
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
            DataGridInserts();
            comboBoxWorker.DataSource = WorkerController.GetAllWorkersInfoForCombo();
            comboBoxWorker.DisplayMember = "Имя";
            comboBoxWorker.ValueMember = "ID";
        }

        public void DataGridInserts()
        {
            dataGridView1.DataSource = WorkerController.GetAllPosts();
            dataGridView2.DataSource = RequestsController.GetAllStatus();
            dataGridView3.DataSource = AuthorizationController.GetAllUsers();
            dataGridView1.Columns[dataGridView1.ColumnCount-1].Visible = false;
            dataGridView2.Columns[dataGridView2.ColumnCount-1].Visible = false;
            dataGridView3.Columns[dataGridView3.ColumnCount-1].Visible = false;
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            Posts post = new Posts();
            post.Name = textBoxNamePost.Text;
            WorkerController.AddPost(post);
            DataGridInserts();
        }

        private void buttonAddStatus_Click(object sender, EventArgs e)
        {
            StatusRequests status = new StatusRequests();
            status.Description = richTextBoxDescStatus.Text;
            status.Name = textBoxNameStatus.Text;
            RequestsController.AddStatus(status);
            DataGridInserts();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Login = textBoxLogin.Text;
            user.Password = textBoxPassword.Text;
            user.Worker_ID = (int)comboBoxWorker.SelectedValue;
            AuthorizationController.UserAdd(user);
            DataGridInserts();
        }
    }
}
