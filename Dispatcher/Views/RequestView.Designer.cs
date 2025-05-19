namespace Dispatcher.Views
{
    partial class RequestView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxResponsible = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDispatcher = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.buttonSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(35, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(114, 32);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Запрос";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxID.Location = new System.Drawing.Point(123, 83);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(121, 31);
            this.textBoxID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.Location = new System.Drawing.Point(123, 120);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(311, 31);
            this.textBoxTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Описание";
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDesc.Location = new System.Drawing.Point(123, 163);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(311, 137);
            this.richTextBoxDesc.TabIndex = 11;
            this.richTextBoxDesc.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(123, 306);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(311, 30);
            this.comboBoxStatus.TabIndex = 16;
            // 
            // comboBoxResponsible
            // 
            this.comboBoxResponsible.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxResponsible.FormattingEnabled = true;
            this.comboBoxResponsible.Location = new System.Drawing.Point(123, 344);
            this.comboBoxResponsible.Name = "comboBoxResponsible";
            this.comboBoxResponsible.Size = new System.Drawing.Size(311, 30);
            this.comboBoxResponsible.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ответственный";
            // 
            // comboBoxDispatcher
            // 
            this.comboBoxDispatcher.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDispatcher.FormattingEnabled = true;
            this.comboBoxDispatcher.Location = new System.Drawing.Point(123, 382);
            this.comboBoxDispatcher.Name = "comboBoxDispatcher";
            this.comboBoxDispatcher.Size = new System.Drawing.Size(311, 30);
            this.comboBoxDispatcher.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(38, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Диспетчер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(282, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Дата создания";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(276, 94);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerEnd.TabIndex = 24;
            // 
            // buttonDelete
            // 
            this.buttonDelete.AllowAnimations = true;
            this.buttonDelete.AllowMouseEffects = true;
            this.buttonDelete.AllowToggling = false;
            this.buttonDelete.AnimationSpeed = 200;
            this.buttonDelete.AutoGenerateColors = false;
            this.buttonDelete.AutoRoundBorders = false;
            this.buttonDelete.AutoSizeLeftIcon = true;
            this.buttonDelete.AutoSizeRightIcon = true;
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
            this.buttonDelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dot;
            this.buttonDelete.ButtonText = "Удалить";
            this.buttonDelete.ButtonTextMarginLeft = 0;
            this.buttonDelete.ColorContrastOnClick = 45;
            this.buttonDelete.ColorContrastOnHover = 45;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonDelete.CustomizableEdges = borderEdges1;
            this.buttonDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonDelete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonDelete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonDelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonDelete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonDelete.IconMarginLeft = 11;
            this.buttonDelete.IconPadding = 10;
            this.buttonDelete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonDelete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonDelete.IconSize = 25;
            this.buttonDelete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonDelete.IdleBorderRadius = 1;
            this.buttonDelete.IdleBorderThickness = 1;
            this.buttonDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonDelete.IdleIconLeftImage = null;
            this.buttonDelete.IdleIconRightImage = null;
            this.buttonDelete.IndicateFocus = false;
            this.buttonDelete.Location = new System.Drawing.Point(123, 420);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonDelete.OnDisabledState.BorderRadius = 1;
            this.buttonDelete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonDelete.OnDisabledState.BorderThickness = 1;
            this.buttonDelete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonDelete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonDelete.OnDisabledState.IconLeftImage = null;
            this.buttonDelete.OnDisabledState.IconRightImage = null;
            this.buttonDelete.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonDelete.onHoverState.BorderRadius = 1;
            this.buttonDelete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonDelete.onHoverState.BorderThickness = 1;
            this.buttonDelete.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonDelete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.onHoverState.IconLeftImage = null;
            this.buttonDelete.onHoverState.IconRightImage = null;
            this.buttonDelete.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonDelete.OnIdleState.BorderRadius = 1;
            this.buttonDelete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dot;
            this.buttonDelete.OnIdleState.BorderThickness = 1;
            this.buttonDelete.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonDelete.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.OnIdleState.IconLeftImage = null;
            this.buttonDelete.OnIdleState.IconRightImage = null;
            this.buttonDelete.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonDelete.OnPressedState.BorderRadius = 1;
            this.buttonDelete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonDelete.OnPressedState.BorderThickness = 1;
            this.buttonDelete.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonDelete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.OnPressedState.IconLeftImage = null;
            this.buttonDelete.OnPressedState.IconRightImage = null;
            this.buttonDelete.Size = new System.Drawing.Size(86, 30);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonDelete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonDelete.TextMarginLeft = 0;
            this.buttonDelete.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonDelete.UseDefaultRadiusAndThickness = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonSave
            // 
            this.buttonSave.AllowAnimations = true;
            this.buttonSave.AllowMouseEffects = true;
            this.buttonSave.AllowToggling = false;
            this.buttonSave.AnimationSpeed = 200;
            this.buttonSave.AutoGenerateColors = false;
            this.buttonSave.AutoRoundBorders = false;
            this.buttonSave.AutoSizeLeftIcon = true;
            this.buttonSave.AutoSizeRightIcon = true;
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
            this.buttonSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dot;
            this.buttonSave.ButtonText = "Сохранить";
            this.buttonSave.ButtonTextMarginLeft = 0;
            this.buttonSave.ColorContrastOnClick = 45;
            this.buttonSave.ColorContrastOnHover = 45;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.buttonSave.CustomizableEdges = borderEdges2;
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonSave.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonSave.IconMarginLeft = 11;
            this.buttonSave.IconPadding = 10;
            this.buttonSave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonSave.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonSave.IconSize = 25;
            this.buttonSave.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonSave.IdleBorderRadius = 1;
            this.buttonSave.IdleBorderThickness = 1;
            this.buttonSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonSave.IdleIconLeftImage = null;
            this.buttonSave.IdleIconRightImage = null;
            this.buttonSave.IndicateFocus = false;
            this.buttonSave.Location = new System.Drawing.Point(348, 420);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSave.OnDisabledState.BorderRadius = 1;
            this.buttonSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSave.OnDisabledState.BorderThickness = 1;
            this.buttonSave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonSave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonSave.OnDisabledState.IconLeftImage = null;
            this.buttonSave.OnDisabledState.IconRightImage = null;
            this.buttonSave.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonSave.onHoverState.BorderRadius = 1;
            this.buttonSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSave.onHoverState.BorderThickness = 1;
            this.buttonSave.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonSave.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonSave.onHoverState.IconLeftImage = null;
            this.buttonSave.onHoverState.IconRightImage = null;
            this.buttonSave.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonSave.OnIdleState.BorderRadius = 1;
            this.buttonSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dot;
            this.buttonSave.OnIdleState.BorderThickness = 1;
            this.buttonSave.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonSave.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonSave.OnIdleState.IconLeftImage = null;
            this.buttonSave.OnIdleState.IconRightImage = null;
            this.buttonSave.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonSave.OnPressedState.BorderRadius = 1;
            this.buttonSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSave.OnPressedState.BorderThickness = 1;
            this.buttonSave.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonSave.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonSave.OnPressedState.IconLeftImage = null;
            this.buttonSave.OnPressedState.IconRightImage = null;
            this.buttonSave.Size = new System.Drawing.Size(86, 30);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonSave.TextMarginLeft = 0;
            this.buttonSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonSave.UseDefaultRadiusAndThickness = true;
            this.buttonSave.Click += new System.EventHandler(this.bunifuButton21_Click);
            // 
            // RequestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(493, 500);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxDispatcher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxResponsible);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(509, 539);
            this.MinimumSize = new System.Drawing.Size(509, 539);
            this.Name = "RequestView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый запрос";
            this.Load += new System.EventHandler(this.RequestView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxResponsible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDispatcher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonDelete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonSave;
    }
}