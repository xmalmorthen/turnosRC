namespace turnosAdministrator
{
    partial class frmLogIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.txtUsr = new MetroFramework.Controls.MetroTextBox();
            this.btnLogIn = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbSpnr = new MetroFramework.Controls.MetroProgressSpinner();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(400, 2);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.DisplayIcon = true;
            this.txtPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPass.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtPass.Icon")));
            this.txtPass.Lines = new string[] {
        "123456789"};
            this.txtPass.Location = new System.Drawing.Point(30, 172);
            this.txtPass.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShowClearButton = true;
            this.txtPass.Size = new System.Drawing.Size(440, 42);
            this.txtPass.TabIndex = 7;
            this.txtPass.Text = "123456789";
            this.metroToolTip1.SetToolTip(this.txtPass, "Nombre de usuario");
            this.txtPass.UseSelectable = true;
            this.txtPass.UseStyleColors = true;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsr
            // 
            this.txtUsr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtUsr.CustomButton.Image = null;
            this.txtUsr.CustomButton.Location = new System.Drawing.Point(400, 2);
            this.txtUsr.CustomButton.Name = "";
            this.txtUsr.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtUsr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsr.CustomButton.TabIndex = 1;
            this.txtUsr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsr.CustomButton.UseSelectable = true;
            this.txtUsr.CustomButton.Visible = false;
            this.txtUsr.DisplayIcon = true;
            this.txtUsr.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUsr.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtUsr.Icon = global::turnosAdministrator.Properties.Resources.user;
            this.txtUsr.Lines = new string[] {
        "usuarioprueba"};
            this.txtUsr.Location = new System.Drawing.Point(30, 92);
            this.txtUsr.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtUsr.MaxLength = 32767;
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.PasswordChar = '\0';
            this.txtUsr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsr.SelectedText = "";
            this.txtUsr.SelectionLength = 0;
            this.txtUsr.SelectionStart = 0;
            this.txtUsr.ShowClearButton = true;
            this.txtUsr.Size = new System.Drawing.Size(440, 42);
            this.txtUsr.TabIndex = 6;
            this.txtUsr.Text = "usuarioprueba";
            this.metroToolTip1.SetToolTip(this.txtUsr, "Nombre de usuario");
            this.txtUsr.UseSelectable = true;
            this.txtUsr.UseStyleColors = true;
            this.txtUsr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogIn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLogIn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLogIn.Location = new System.Drawing.Point(318, 227);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(73, 28);
            this.btnLogIn.TabIndex = 12;
            this.btnLogIn.Text = "Entrar";
            this.metroToolTip1.SetToolTip(this.btnLogIn, "Iniciar sesión");
            this.btnLogIn.UseSelectable = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCancel.Location = new System.Drawing.Point(397, 227);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 28);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancelar";
            this.metroToolTip1.SetToolTip(this.btnCancel, "Cancelar el inicio de sesión");
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroStyleExtender
            // 
            this.metroStyleExtender.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Silver;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(30, 144);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 25);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Contraseña";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(30, 64);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 25);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pbSpnr
            // 
            this.pbSpnr.Location = new System.Drawing.Point(274, 223);
            this.pbSpnr.Maximum = 100;
            this.pbSpnr.Name = "pbSpnr";
            this.pbSpnr.Size = new System.Drawing.Size(32, 32);
            this.pbSpnr.TabIndex = 15;
            this.pbSpnr.TabStop = false;
            this.pbSpnr.UseSelectable = true;
            this.pbSpnr.Value = 50;
            this.pbSpnr.Visible = false;
            // 
            // frmLogIn
            // 
            this.AcceptButton = this.btnLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackImagePadding = new System.Windows.Forms.Padding(10);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(500, 265);
            this.Controls.Add(this.pbSpnr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtUsr);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 265);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(381, 265);
            this.Name = "frmLogIn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroButton btnLogIn;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUsr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroProgressSpinner pbSpnr;
    }
}