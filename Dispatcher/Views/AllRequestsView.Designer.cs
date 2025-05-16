namespace Dispatcher.Views
{
    partial class AllRequestsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllRequestsView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefill = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSort = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxStatus = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.chkPassword = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.dispatcherDataSet11 = new Dispatcher.DispatcherDataSet1();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatcherDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.buttonRefill);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 49);
            this.panel1.TabIndex = 2;
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
            this.buttonRefill.ButtonText = "Запросы";
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
            this.buttonRefill.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.buttonRefill.Location = new System.Drawing.Point(446, -1);
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
            this.buttonRefill.Size = new System.Drawing.Size(194, 50);
            this.buttonRefill.TabIndex = 6;
            this.buttonRefill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonRefill.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonRefill.TextMarginLeft = 0;
            this.buttonRefill.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonRefill.UseDefaultRadiusAndThickness = true;
            this.buttonRefill.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.checkBoxSort);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(322, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 33);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cортировать";
            // 
            // checkBoxSort
            // 
            this.checkBoxSort.AllowBindingControlAnimation = true;
            this.checkBoxSort.AllowBindingControlColorChanges = false;
            this.checkBoxSort.AllowBindingControlLocation = true;
            this.checkBoxSort.AllowCheckBoxAnimation = false;
            this.checkBoxSort.AllowCheckmarkAnimation = true;
            this.checkBoxSort.AllowOnHoverStates = true;
            this.checkBoxSort.AutoCheck = true;
            this.checkBoxSort.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBoxSort.BackgroundImage")));
            this.checkBoxSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxSort.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkBoxSort.BorderRadius = 12;
            this.checkBoxSort.Checked = false;
            this.checkBoxSort.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.checkBoxSort.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxSort.CustomCheckmarkImage = null;
            this.checkBoxSort.Location = new System.Drawing.Point(6, 6);
            this.checkBoxSort.MinimumSize = new System.Drawing.Size(17, 17);
            this.checkBoxSort.Name = "checkBoxSort";
            this.checkBoxSort.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.checkBoxSort.OnCheck.BorderRadius = 12;
            this.checkBoxSort.OnCheck.BorderThickness = 2;
            this.checkBoxSort.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.checkBoxSort.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkBoxSort.OnCheck.CheckmarkThickness = 2;
            this.checkBoxSort.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkBoxSort.OnDisable.BorderRadius = 12;
            this.checkBoxSort.OnDisable.BorderThickness = 2;
            this.checkBoxSort.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxSort.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkBoxSort.OnDisable.CheckmarkThickness = 2;
            this.checkBoxSort.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBoxSort.OnHoverChecked.BorderRadius = 12;
            this.checkBoxSort.OnHoverChecked.BorderThickness = 2;
            this.checkBoxSort.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBoxSort.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkBoxSort.OnHoverChecked.CheckmarkThickness = 2;
            this.checkBoxSort.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBoxSort.OnHoverUnchecked.BorderRadius = 12;
            this.checkBoxSort.OnHoverUnchecked.BorderThickness = 1;
            this.checkBoxSort.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxSort.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.checkBoxSort.OnUncheck.BorderRadius = 12;
            this.checkBoxSort.OnUncheck.BorderThickness = 1;
            this.checkBoxSort.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxSort.Size = new System.Drawing.Size(21, 21);
            this.checkBoxSort.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkBoxSort.TabIndex = 5;
            this.checkBoxSort.ThreeState = false;
            this.checkBoxSort.ToolTipText = null;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBoxStatus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 33);
            this.panel3.TabIndex = 5;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxStatus.BackgroundColor = System.Drawing.Color.White;
            this.comboBoxStatus.BorderColor = System.Drawing.Color.Silver;
            this.comboBoxStatus.BorderRadius = 1;
            this.comboBoxStatus.Color = System.Drawing.Color.Silver;
            this.comboBoxStatus.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.comboBoxStatus.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboBoxStatus.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboBoxStatus.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboBoxStatus.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboBoxStatus.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.comboBoxStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBoxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxStatus.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboBoxStatus.FillDropDown = true;
            this.comboBoxStatus.FillIndicator = false;
            this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.ForeColor = System.Drawing.Color.Black;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Icon = null;
            this.comboBoxStatus.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboBoxStatus.IndicatorColor = System.Drawing.Color.DarkGray;
            this.comboBoxStatus.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboBoxStatus.IndicatorThickness = 2;
            this.comboBoxStatus.IsDropdownOpened = false;
            this.comboBoxStatus.ItemBackColor = System.Drawing.Color.White;
            this.comboBoxStatus.ItemBorderColor = System.Drawing.Color.White;
            this.comboBoxStatus.ItemForeColor = System.Drawing.Color.Black;
            this.comboBoxStatus.ItemHeight = 26;
            this.comboBoxStatus.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.comboBoxStatus.ItemHighLightForeColor = System.Drawing.Color.White;
            this.comboBoxStatus.ItemTopMargin = 3;
            this.comboBoxStatus.Location = new System.Drawing.Point(0, 1);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(322, 32);
            this.comboBoxStatus.TabIndex = 0;
            this.comboBoxStatus.Text = null;
            this.comboBoxStatus.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboBoxStatus.TextLeftMargin = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Статус";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewRequests);
            this.panel2.Controls.Add(this.chkPassword);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 473);
            this.panel2.TabIndex = 3;
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Location = new System.Drawing.Point(-3, 73);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRequests.Size = new System.Drawing.Size(640, 473);
            this.dataGridViewRequests.TabIndex = 0;
            this.dataGridViewRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequests_CellContentClick);
            this.dataGridViewRequests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequests_CellDoubleClick);
            // 
            // chkPassword
            // 
            this.chkPassword.AllowBindingControlAnimation = true;
            this.chkPassword.AllowBindingControlColorChanges = false;
            this.chkPassword.AllowBindingControlLocation = true;
            this.chkPassword.AllowCheckBoxAnimation = false;
            this.chkPassword.AllowCheckmarkAnimation = true;
            this.chkPassword.AllowOnHoverStates = true;
            this.chkPassword.AutoCheck = true;
            this.chkPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkPassword.BackgroundImage")));
            this.chkPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkPassword.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkPassword.BorderRadius = 12;
            this.chkPassword.Checked = false;
            this.chkPassword.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.chkPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkPassword.CustomCheckmarkImage = null;
            this.chkPassword.Location = new System.Drawing.Point(229, 163);
            this.chkPassword.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.chkPassword.OnCheck.BorderRadius = 12;
            this.chkPassword.OnCheck.BorderThickness = 2;
            this.chkPassword.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.chkPassword.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkPassword.OnCheck.CheckmarkThickness = 2;
            this.chkPassword.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkPassword.OnDisable.BorderRadius = 12;
            this.chkPassword.OnDisable.BorderThickness = 2;
            this.chkPassword.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkPassword.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkPassword.OnDisable.CheckmarkThickness = 2;
            this.chkPassword.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.chkPassword.OnHoverChecked.BorderRadius = 12;
            this.chkPassword.OnHoverChecked.BorderThickness = 2;
            this.chkPassword.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.chkPassword.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkPassword.OnHoverChecked.CheckmarkThickness = 2;
            this.chkPassword.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.chkPassword.OnHoverUnchecked.BorderRadius = 12;
            this.chkPassword.OnHoverUnchecked.BorderThickness = 1;
            this.chkPassword.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkPassword.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.chkPassword.OnUncheck.BorderRadius = 12;
            this.chkPassword.OnUncheck.BorderThickness = 1;
            this.chkPassword.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkPassword.Size = new System.Drawing.Size(21, 21);
            this.chkPassword.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkPassword.TabIndex = 4;
            this.chkPassword.ThreeState = false;
            this.chkPassword.ToolTipText = null;
            // 
            // dispatcherDataSet11
            // 
            this.dispatcherDataSet11.DataSetName = "DispatcherDataSet1";
            this.dispatcherDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AllRequestsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(640, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllRequestsView";
            this.Text = "Запросы";
            this.Load += new System.EventHandler(this.AllRequestsView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatcherDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private DispatcherDataSet1 dispatcherDataSet11;
        private Bunifu.UI.WinForms.BunifuCheckBox chkPassword;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuDropdown comboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuCheckBox checkBoxSort;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonRefill;
    }
}