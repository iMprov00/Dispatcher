namespace Dispatcher.Views
{
    partial class AllWorkersView
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllWorkersView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.buttonRefill = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.dataGridViewWorkers = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonRefill);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 45);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AllowAnimations = true;
            this.buttonAdd.AllowMouseEffects = true;
            this.buttonAdd.AllowToggling = false;
            this.buttonAdd.AnimationSpeed = 200;
            this.buttonAdd.AutoGenerateColors = false;
            this.buttonAdd.AutoRoundBorders = false;
            this.buttonAdd.AutoSizeLeftIcon = true;
            this.buttonAdd.AutoSizeRightIcon = true;
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.BackgroundImage")));
            this.buttonAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dot;
            this.buttonAdd.ButtonText = "Добавить";
            this.buttonAdd.ButtonTextMarginLeft = 0;
            this.buttonAdd.ColorContrastOnClick = 45;
            this.buttonAdd.ColorContrastOnHover = 45;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.buttonAdd.CustomizableEdges = borderEdges2;
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonAdd.IconMarginLeft = 11;
            this.buttonAdd.IconPadding = 10;
            this.buttonAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonAdd.IconSize = 25;
            this.buttonAdd.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonAdd.IdleBorderRadius = 1;
            this.buttonAdd.IdleBorderThickness = 1;
            this.buttonAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonAdd.IdleIconLeftImage = null;
            this.buttonAdd.IdleIconRightImage = null;
            this.buttonAdd.IndicateFocus = false;
            this.buttonAdd.Location = new System.Drawing.Point(661, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonAdd.OnDisabledState.BorderRadius = 1;
            this.buttonAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonAdd.OnDisabledState.BorderThickness = 1;
            this.buttonAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonAdd.OnDisabledState.IconLeftImage = null;
            this.buttonAdd.OnDisabledState.IconRightImage = null;
            this.buttonAdd.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonAdd.onHoverState.BorderRadius = 1;
            this.buttonAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonAdd.onHoverState.BorderThickness = 1;
            this.buttonAdd.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonAdd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.onHoverState.IconLeftImage = null;
            this.buttonAdd.onHoverState.IconRightImage = null;
            this.buttonAdd.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonAdd.OnIdleState.BorderRadius = 1;
            this.buttonAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dot;
            this.buttonAdd.OnIdleState.BorderThickness = 1;
            this.buttonAdd.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.OnIdleState.IconLeftImage = null;
            this.buttonAdd.OnIdleState.IconRightImage = null;
            this.buttonAdd.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonAdd.OnPressedState.BorderRadius = 1;
            this.buttonAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonAdd.OnPressedState.BorderThickness = 1;
            this.buttonAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.OnPressedState.IconLeftImage = null;
            this.buttonAdd.OnPressedState.IconRightImage = null;
            this.buttonAdd.Size = new System.Drawing.Size(86, 43);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonAdd.TextMarginLeft = 0;
            this.buttonAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonAdd.UseDefaultRadiusAndThickness = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonRefill
            // 
            this.buttonRefill.AllowAnimations = true;
            this.buttonRefill.AllowMouseEffects = true;
            this.buttonRefill.AllowToggling = false;
            this.buttonRefill.AnimationSpeed = 200;
            this.buttonRefill.AutoGenerateColors = false;
            this.buttonRefill.AutoRoundBorders = false;
            this.buttonRefill.AutoSizeLeftIcon = true;
            this.buttonRefill.AutoSizeRightIcon = true;
            this.buttonRefill.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefill.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonRefill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefill.BackgroundImage")));
            this.buttonRefill.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dot;
            this.buttonRefill.ButtonText = "Обновить";
            this.buttonRefill.ButtonTextMarginLeft = 0;
            this.buttonRefill.ColorContrastOnClick = 45;
            this.buttonRefill.ColorContrastOnHover = 45;
            this.buttonRefill.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonRefill.CustomizableEdges = borderEdges1;
            this.buttonRefill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonRefill.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonRefill.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonRefill.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonRefill.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRefill.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonRefill.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefill.ForeColor = System.Drawing.Color.White;
            this.buttonRefill.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefill.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonRefill.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonRefill.IconMarginLeft = 11;
            this.buttonRefill.IconPadding = 10;
            this.buttonRefill.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefill.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonRefill.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonRefill.IconSize = 25;
            this.buttonRefill.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonRefill.IdleBorderRadius = 1;
            this.buttonRefill.IdleBorderThickness = 1;
            this.buttonRefill.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonRefill.IdleIconLeftImage = null;
            this.buttonRefill.IdleIconRightImage = null;
            this.buttonRefill.IndicateFocus = false;
            this.buttonRefill.Location = new System.Drawing.Point(575, 0);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonRefill.OnDisabledState.BorderRadius = 1;
            this.buttonRefill.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonRefill.OnDisabledState.BorderThickness = 1;
            this.buttonRefill.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonRefill.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonRefill.OnDisabledState.IconLeftImage = null;
            this.buttonRefill.OnDisabledState.IconRightImage = null;
            this.buttonRefill.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonRefill.onHoverState.BorderRadius = 1;
            this.buttonRefill.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonRefill.onHoverState.BorderThickness = 1;
            this.buttonRefill.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonRefill.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonRefill.onHoverState.IconLeftImage = null;
            this.buttonRefill.onHoverState.IconRightImage = null;
            this.buttonRefill.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonRefill.OnIdleState.BorderRadius = 1;
            this.buttonRefill.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dot;
            this.buttonRefill.OnIdleState.BorderThickness = 1;
            this.buttonRefill.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonRefill.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonRefill.OnIdleState.IconLeftImage = null;
            this.buttonRefill.OnIdleState.IconRightImage = null;
            this.buttonRefill.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonRefill.OnPressedState.BorderRadius = 1;
            this.buttonRefill.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonRefill.OnPressedState.BorderThickness = 1;
            this.buttonRefill.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonRefill.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonRefill.OnPressedState.IconLeftImage = null;
            this.buttonRefill.OnPressedState.IconRightImage = null;
            this.buttonRefill.Size = new System.Drawing.Size(86, 43);
            this.buttonRefill.TabIndex = 7;
            this.buttonRefill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonRefill.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonRefill.TextMarginLeft = 0;
            this.buttonRefill.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonRefill.UseDefaultRadiusAndThickness = true;
            this.buttonRefill.Click += new System.EventHandler(this.buttonRefill_Click_1);
            // 
            // dataGridViewWorkers
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewWorkers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewWorkers.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWorkers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWorkers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWorkers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWorkers.Name = "dataGridViewWorkers";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWorkers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewWorkers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWorkers.Size = new System.Drawing.Size(749, 532);
            this.dataGridViewWorkers.TabIndex = 0;
            this.dataGridViewWorkers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWorkers_CellContentClick);
            this.dataGridViewWorkers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWorkers_CellDoubleClick);
            // 
            // AllWorkersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 532);
            this.Controls.Add(this.dataGridViewWorkers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(749, 532);
            this.MinimumSize = new System.Drawing.Size(749, 532);
            this.Name = "AllWorkersView";
            this.Text = "Работники";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AllWorkersView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonAdd;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonRefill;
        private System.Windows.Forms.DataGridView dataGridViewWorkers;
    }
}