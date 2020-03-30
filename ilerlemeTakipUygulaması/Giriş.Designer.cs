namespace ilerlemeTakipUygulaması
{
    partial class giriş
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giriş));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.btngiris = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtgsifre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(28, 243);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 19);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "KAYIT OL";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuCheckBox1);
            this.panel1.Controls.Add(this.btngiris);
            this.panel1.Controls.Add(this.txtgsifre);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 292);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(78, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Beni Hatırla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Şifre";
            // 
            // bunifuCheckBox1
            // 
            this.bunifuCheckBox1.AllowBindingControlAnimation = true;
            this.bunifuCheckBox1.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox1.AllowBindingControlLocation = true;
            this.bunifuCheckBox1.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox1.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox1.AllowOnHoverStates = true;
            this.bunifuCheckBox1.AutoCheck = true;
            this.bunifuCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox1.BackgroundImage")));
            this.bunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox1.BindingControl = null;
            this.bunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox1.Checked = false;
            this.bunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.bunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox1.CustomCheckmarkImage = null;
            this.bunifuCheckBox1.Location = new System.Drawing.Point(40, 148);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.BorderRadius = 1;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 1;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 1;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 1;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 1;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Flat;
            this.bunifuCheckBox1.TabIndex = 7;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = null;
            // 
            // btngiris
            // 
            this.btngiris.AllowToggling = false;
            this.btngiris.AnimationSpeed = 200;
            this.btngiris.AutoGenerateColors = false;
            this.btngiris.BackColor = System.Drawing.Color.Transparent;
            this.btngiris.BackColor1 = System.Drawing.Color.SeaGreen;
            this.btngiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngiris.BackgroundImage")));
            this.btngiris.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btngiris.ButtonText = "Giriş";
            this.btngiris.ButtonTextMarginLeft = 0;
            this.btngiris.ColorContrastOnClick = 45;
            this.btngiris.ColorContrastOnHover = 45;
            this.btngiris.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btngiris.CustomizableEdges = borderEdges1;
            this.btngiris.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btngiris.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btngiris.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btngiris.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btngiris.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btngiris.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.ForeColor = System.Drawing.Color.White;
            this.btngiris.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btngiris.IconMarginLeft = 11;
            this.btngiris.IconPadding = 10;
            this.btngiris.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btngiris.IdleBorderColor = System.Drawing.Color.Azure;
            this.btngiris.IdleBorderRadius = 1;
            this.btngiris.IdleBorderThickness = 1;
            this.btngiris.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btngiris.IdleIconLeftImage = null;
            this.btngiris.IdleIconRightImage = null;
            this.btngiris.IndicateFocus = false;
            this.btngiris.Location = new System.Drawing.Point(134, 184);
            this.btngiris.Name = "btngiris";
            this.btngiris.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btngiris.onHoverState.BorderRadius = 1;
            this.btngiris.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btngiris.onHoverState.BorderThickness = 1;
            this.btngiris.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btngiris.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btngiris.onHoverState.IconLeftImage = null;
            this.btngiris.onHoverState.IconRightImage = null;
            this.btngiris.OnIdleState.BorderColor = System.Drawing.Color.Azure;
            this.btngiris.OnIdleState.BorderRadius = 1;
            this.btngiris.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btngiris.OnIdleState.BorderThickness = 1;
            this.btngiris.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.btngiris.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btngiris.OnIdleState.IconLeftImage = null;
            this.btngiris.OnIdleState.IconRightImage = null;
            this.btngiris.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btngiris.OnPressedState.BorderRadius = 1;
            this.btngiris.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btngiris.OnPressedState.BorderThickness = 1;
            this.btngiris.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btngiris.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btngiris.OnPressedState.IconLeftImage = null;
            this.btngiris.OnPressedState.IconRightImage = null;
            this.btngiris.Size = new System.Drawing.Size(150, 39);
            this.btngiris.TabIndex = 6;
            this.btngiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btngiris.TextMarginLeft = 0;
            this.btngiris.UseDefaultRadiusAndThickness = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click_1);
            // 
            // txtgsifre
            // 
            this.txtgsifre.AcceptsReturn = false;
            this.txtgsifre.AcceptsTab = false;
            this.txtgsifre.AnimationSpeed = 200;
            this.txtgsifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtgsifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtgsifre.BackColor = System.Drawing.Color.Transparent;
            this.txtgsifre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtgsifre.BackgroundImage")));
            this.txtgsifre.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtgsifre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtgsifre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtgsifre.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtgsifre.BorderRadius = 1;
            this.txtgsifre.BorderThickness = 1;
            this.txtgsifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtgsifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgsifre.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtgsifre.DefaultText = "";
            this.txtgsifre.FillColor = System.Drawing.Color.LightGray;
            this.txtgsifre.HideSelection = true;
            this.txtgsifre.IconLeft = null;
            this.txtgsifre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgsifre.IconPadding = 10;
            this.txtgsifre.IconRight = ((System.Drawing.Image)(resources.GetObject("txtgsifre.IconRight")));
            this.txtgsifre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgsifre.Lines = new string[0];
            this.txtgsifre.Location = new System.Drawing.Point(130, 82);
            this.txtgsifre.MaxLength = 32767;
            this.txtgsifre.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtgsifre.Modified = false;
            this.txtgsifre.Multiline = false;
            this.txtgsifre.Name = "txtgsifre";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtgsifre.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtgsifre.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtgsifre.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.LightGray;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtgsifre.OnIdleState = stateProperties4;
            this.txtgsifre.PasswordChar = '\0';
            this.txtgsifre.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtgsifre.PlaceholderText = "Şifre";
            this.txtgsifre.ReadOnly = false;
            this.txtgsifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtgsifre.SelectedText = "";
            this.txtgsifre.SelectionLength = 0;
            this.txtgsifre.SelectionStart = 0;
            this.txtgsifre.ShortcutsEnabled = true;
            this.txtgsifre.Size = new System.Drawing.Size(179, 35);
            this.txtgsifre.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtgsifre.TabIndex = 5;
            this.txtgsifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtgsifre.TextMarginBottom = 0;
            this.txtgsifre.TextMarginLeft = 3;
            this.txtgsifre.TextMarginTop = 0;
            this.txtgsifre.TextPlaceholder = "Şifre";
            this.txtgsifre.UseSystemPasswordChar = false;
            this.txtgsifre.WordWrap = true;
            // 
            // giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 293);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.giriş_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btngiris;
        private Bunifu.UI.WinForms.BunifuTextBox txtgsifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

