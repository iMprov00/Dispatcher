namespace Dispatcher
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panelSystems = new System.Windows.Forms.Panel();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonWorkers = new System.Windows.Forms.Button();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelSystems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSystems
            // 
            this.panelSystems.Controls.Add(this.buttonAdmin);
            this.panelSystems.Controls.Add(this.buttonExit);
            this.panelSystems.Controls.Add(this.buttonWorkers);
            this.panelSystems.Controls.Add(this.buttonRequest);
            this.panelSystems.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSystems.Location = new System.Drawing.Point(0, 0);
            this.panelSystems.Name = "panelSystems";
            this.panelSystems.Size = new System.Drawing.Size(135, 574);
            this.panelSystems.TabIndex = 1;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdmin.Location = new System.Drawing.Point(0, 94);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(135, 50);
            this.buttonAdmin.TabIndex = 4;
            this.buttonAdmin.Text = "Администрирование";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.Location = new System.Drawing.Point(0, 543);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(135, 31);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonWorkers
            // 
            this.buttonWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWorkers.Location = new System.Drawing.Point(0, 47);
            this.buttonWorkers.Name = "buttonWorkers";
            this.buttonWorkers.Size = new System.Drawing.Size(135, 47);
            this.buttonWorkers.TabIndex = 2;
            this.buttonWorkers.Text = "Работники";
            this.buttonWorkers.UseVisualStyleBackColor = true;
            this.buttonWorkers.Click += new System.EventHandler(this.buttonWorkers_Click);
            // 
            // buttonRequest
            // 
            this.buttonRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRequest.Location = new System.Drawing.Point(0, 0);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(135, 47);
            this.buttonRequest.TabIndex = 1;
            this.buttonRequest.Text = "Запросы";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // panelBase
            // 
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(135, 0);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(951, 574);
            this.panelBase.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 574);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelSystems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSystems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSystems;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.Button buttonWorkers;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAdmin;
        public System.Windows.Forms.Panel panelBase;
    }
}