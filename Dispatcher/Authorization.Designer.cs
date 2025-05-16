namespace Dispatcher
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPassword = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnAuth = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(74, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(138, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Авторизация";
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
            this.chkPassword.Location = new System.Drawing.Point(77, 238);
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
            this.chkPassword.TabIndex = 3;
            this.chkPassword.ThreeState = false;
            this.chkPassword.ToolTipText = null;
            this.chkPassword.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.chkPassword_CheckedChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(104, 242);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(100, 17);
            this.bunifuLabel1.TabIndex = 9;
            this.bunifuLabel1.Text = "Показать пароль";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(77, 184);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(77, 122);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(300, 23);
            this.txtLogin.TabIndex = 1;
            // 
            // btnAuth
            // 
            this.btnAuth.AllowAnimations = true;
            this.btnAuth.AllowMouseEffects = true;
            this.btnAuth.AllowToggling = false;
            this.btnAuth.AnimationSpeed = 200;
            this.btnAuth.AutoGenerateColors = false;
            this.btnAuth.AutoRoundBorders = false;
            this.btnAuth.AutoSizeLeftIcon = true;
            this.btnAuth.AutoSizeRightIcon = true;
            this.btnAuth.BackColor = System.Drawing.Color.Transparent;
            this.btnAuth.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAuth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAuth.BackgroundImage")));
            this.btnAuth.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAuth.ButtonText = "Войти";
            this.btnAuth.ButtonTextMarginLeft = 0;
            this.btnAuth.ColorContrastOnClick = 45;
            this.btnAuth.ColorContrastOnHover = 45;
            this.btnAuth.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAuth.CustomizableEdges = borderEdges1;
            this.btnAuth.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAuth.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAuth.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAuth.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAuth.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnAuth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuth.ForeColor = System.Drawing.Color.White;
            this.btnAuth.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuth.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAuth.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAuth.IconMarginLeft = 11;
            this.btnAuth.IconPadding = 10;
            this.btnAuth.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAuth.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAuth.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAuth.IconSize = 25;
            this.btnAuth.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAuth.IdleBorderRadius = 1;
            this.btnAuth.IdleBorderThickness = 1;
            this.btnAuth.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAuth.IdleIconLeftImage = null;
            this.btnAuth.IdleIconRightImage = null;
            this.btnAuth.IndicateFocus = false;
            this.btnAuth.Location = new System.Drawing.Point(287, 242);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAuth.OnDisabledState.BorderRadius = 1;
            this.btnAuth.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAuth.OnDisabledState.BorderThickness = 1;
            this.btnAuth.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAuth.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAuth.OnDisabledState.IconLeftImage = null;
            this.btnAuth.OnDisabledState.IconRightImage = null;
            this.btnAuth.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAuth.onHoverState.BorderRadius = 1;
            this.btnAuth.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAuth.onHoverState.BorderThickness = 1;
            this.btnAuth.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAuth.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAuth.onHoverState.IconLeftImage = null;
            this.btnAuth.onHoverState.IconRightImage = null;
            this.btnAuth.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAuth.OnIdleState.BorderRadius = 1;
            this.btnAuth.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAuth.OnIdleState.BorderThickness = 1;
            this.btnAuth.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAuth.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAuth.OnIdleState.IconLeftImage = null;
            this.btnAuth.OnIdleState.IconRightImage = null;
            this.btnAuth.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAuth.OnPressedState.BorderRadius = 1;
            this.btnAuth.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAuth.OnPressedState.BorderThickness = 1;
            this.btnAuth.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAuth.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAuth.OnPressedState.IconLeftImage = null;
            this.btnAuth.OnPressedState.IconRightImage = null;
            this.btnAuth.Size = new System.Drawing.Size(90, 39);
            this.btnAuth.TabIndex = 10;
            this.btnAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAuth.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAuth.TextMarginLeft = 0;
            this.btnAuth.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAuth.UseDefaultRadiusAndThickness = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click_1);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(445, 314);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.chkPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuCheckBox chkPassword;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAuth;
    }
}

