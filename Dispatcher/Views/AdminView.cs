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
            // Установка источников данных
            dataGridView1.DataSource = WorkerController.GetAllPosts();
            dataGridView2.DataSource = RequestsController.GetAllStatus();
            dataGridView3.DataSource = AuthorizationController.GetAllUsers();

            // Скрытие последних столбцов
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
            dataGridView2.Columns[dataGridView2.Columns.Count - 1].Visible = false;
            dataGridView3.Columns[dataGridView3.Columns.Count - 1].Visible = false;

            // Настройка автоширины для всех столбцов
            void ConfigureGrid(DataGridView dgv)
            {
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgv.AutoResizeColumns();
                dgv.Columns[dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Опционально
            }

            ConfigureGrid(dataGridView1);
            ConfigureGrid(dataGridView2);
            ConfigureGrid(dataGridView3);
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddStatus_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click_1(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Login = textBoxLogin.Text;
            user.Password = textBoxPassword.Text;
            user.Worker_ID = (int)comboBoxWorker.SelectedValue;
            AuthorizationController.UserAdd(user);
            DataGridInserts();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            StatusRequests status = new StatusRequests();
            status.Description = richTextBoxDescStatus.Text;
            status.Name = textBoxNameStatus.Text;
            RequestsController.AddStatus(status);
            DataGridInserts();
        }

        private void buttonAddPost_Click_1(object sender, EventArgs e)
        {
            Posts post = new Posts();
            post.Name = textBoxNamePost.Text;
            WorkerController.AddPost(post);
            DataGridInserts();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {

        }
    }
}
