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
    public partial class RequestView : Form
    {

        public Requests currentRequest = new Requests();
        public RequestView()
        {
            InitializeComponent();
            ControlsPreLoad();
        }
        public RequestView(int requestId)
        {
            InitializeComponent();
            ControlsPreLoad();
            currentRequest = RequestsController.GetRequest(requestId);
            ControlsFilling(currentRequest);
        }

        public void ControlsFilling(Requests request)
        {
            textBoxTitle.Text = request.Title;
            textBoxID.Text = request.ID.ToString();
            richTextBoxDesc.Text = request.Description;
            comboBoxDispatcher.SelectedValue = request.Dispatcher_ID;
            comboBoxResponsible.SelectedValue = request.Responsible_ID;
            comboBoxStatus.SelectedValue = request.Status_ID;
            if (request.DateCreated != null) 
                dateTimePickerEnd.Value = (DateTime)request.DateCreated;
            this.Text = request.Title;
            labelName.Text += " - " + request.Title;
        }

        public void ControlsPreLoad()
        {
            comboBoxStatus.DataSource = RequestsController.GetAllStatus();
            comboBoxStatus.DisplayMember = "Name";
            comboBoxStatus.ValueMember = "ID";

            comboBoxResponsible.DataSource = WorkerController.GetAllWorkersInfoForCombo();
            comboBoxResponsible.DisplayMember = "Имя";
            comboBoxResponsible.ValueMember = "ID";

            comboBoxDispatcher.DataSource = WorkerController.GetAllWorkersInfoForCombo();
            comboBoxDispatcher.DisplayMember = "Имя";
            comboBoxDispatcher.ValueMember = "ID";

            if (AuthorizationController.workerId != -1)
            {
                comboBoxDispatcher.SelectedValue = AuthorizationController.workerId;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                currentRequest.Dispatcher_ID = (int)comboBoxDispatcher.SelectedValue;
                currentRequest.Responsible_ID = (int)comboBoxResponsible.SelectedValue;
                currentRequest.Status_ID = (int)comboBoxStatus.SelectedValue;
                currentRequest.DateCreated = dateTimePickerEnd.Value;
                currentRequest.Title = textBoxTitle.Text;
                currentRequest.Description = richTextBoxDesc.Text;

                if (currentRequest.ID == 0)
                {
                    RequestsController.InsertRequestInfo(currentRequest);
                    this.Text = currentRequest.Title;
                    labelName.Text += " - " + currentRequest.Title;
                }
                else
                {
                    RequestsController.entities.SaveChanges();
                }

                MessageBox.Show("Данные сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EventAggregator.NotifyDataChanged();
                // Закрываем текущую форму и возвращаемся к AllRequestsView
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (currentRequest.ID != 0)
            {
                if(MessageBox.Show("Вы действиетельно хотите удалить запрос?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    RequestsController.DeleteRequestInfo(currentRequest);
                    this.Close();
                }
            }
        }

        private void RequestView_Load(object sender, EventArgs e)
        {

        }
    }
}
