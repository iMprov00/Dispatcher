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
using System.Windows.Forms.VisualStyles;

namespace Dispatcher.Views
{
    public partial class WorkerView : Form
    {
        Workers currentWorker = new Workers();
        public WorkerView()
        {
            InitializeComponent();
            ControlsPreLoad();
        }
        public WorkerView(int workerId)
        {
            InitializeComponent();
            ControlsPreLoad();
            currentWorker = WorkerController.GetWorker(workerId);
            ControlsFilling(currentWorker);
        }

        public void ControlsFilling(Workers worker)
        {
            textBoxName.Text = worker.Name;
            textBoxSurname.Text = worker.Surname;
            textBox1.Text = worker.Patronymic;
            textBox2.Text = worker.PhoneNumber;
            textBoxID.Text = worker.ID.ToString();
            this.Text = worker.Name + " " + worker.Surname + " " + worker.Patronymic;
        }

        public void ControlsPreLoad()
        {
            comboBoxPost.DataSource = WorkerController.GetAllPosts();
            comboBoxPost.DisplayMember = "Name";
            comboBoxPost.ValueMember = "ID";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                currentWorker.Name = textBoxName.Text;
                currentWorker.Surname = textBoxSurname.Text;
                currentWorker.Patronymic = textBox1.Text;
                currentWorker.PhoneNumber = textBox2.Text;
                currentWorker.Post_ID = (int)comboBoxPost.SelectedValue;
                if (currentWorker.ID == 0)
                {
                    WorkerController.InsertWorkerInfo(currentWorker);
                    this.Text = currentWorker.Name + " " + currentWorker.Surname + " " + currentWorker.Patronymic;
                }
                else
                    WorkerController.entities.SaveChanges();

                MessageBox.Show("Данные сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EventAggregator.NotifyDataChanged();
                // Закрываем текущую форму и возвращаемся 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (currentWorker.ID != 0)
            {
                if (MessageBox.Show("Вы действиетельно хотите удалить работника?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    WorkerController.DeleteWorkerInfo(currentWorker.ID);
                    this.Close();
                }
            }
        }
    }
}
