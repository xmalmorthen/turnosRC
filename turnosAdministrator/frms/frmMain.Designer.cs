﻿namespace turnosAdministrator
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWeatherDescrip = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtWeather = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.btnOk = new MetroFramework.Controls.MetroButton();
            this.btnClean = new MetroFramework.Controls.MetroButton();
            this.gdWeathers = new MetroFramework.Controls.MetroGrid();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.tabCtrl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTurno2Atiende = new MetroFramework.Controls.MetroLabel();
            this.lblVentanilla2Atiende = new MetroFramework.Controls.MetroLabel();
            this.lblServicio2Atiende = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblTurno1Atiende = new MetroFramework.Controls.MetroLabel();
            this.lblVentanilla1Atiende = new MetroFramework.Controls.MetroLabel();
            this.lblServicio1Atiende = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.lblTurnoActual = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnTurnoSiguiente = new MetroFramework.Controls.MetroButton();
            this.cbmVentanillas = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTabPage3 = new System.Windows.Forms.TabPage();
            this.metroContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVentanillaActual = new System.Windows.Forms.Label();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdWeathers)).BeginInit();
            this.tabCtrl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Silver;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroStyleExtender1.SetApplyMetroTheme(this.splitContainer1, true);
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(3, 10);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gdWeathers);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(646, 262);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pnlBtns, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(321, 260);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtWeatherDescrip);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.txtWeather);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 219);
            this.panel1.TabIndex = 0;
            // 
            // txtWeatherDescrip
            // 
            this.txtWeatherDescrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWeatherDescrip.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtWeatherDescrip.CustomButton.Image = null;
            this.txtWeatherDescrip.CustomButton.Location = new System.Drawing.Point(209, 2);
            this.txtWeatherDescrip.CustomButton.Name = "";
            this.txtWeatherDescrip.CustomButton.Size = new System.Drawing.Size(93, 93);
            this.txtWeatherDescrip.CustomButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.txtWeatherDescrip.CustomButton.TabIndex = 1;
            this.txtWeatherDescrip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWeatherDescrip.CustomButton.UseSelectable = true;
            this.txtWeatherDescrip.CustomButton.Visible = false;
            this.txtWeatherDescrip.Lines = new string[0];
            this.txtWeatherDescrip.Location = new System.Drawing.Point(5, 115);
            this.txtWeatherDescrip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 3);
            this.txtWeatherDescrip.MaxLength = 32767;
            this.txtWeatherDescrip.Multiline = true;
            this.txtWeatherDescrip.Name = "txtWeatherDescrip";
            this.txtWeatherDescrip.PasswordChar = '\0';
            this.txtWeatherDescrip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWeatherDescrip.SelectedText = "";
            this.txtWeatherDescrip.SelectionLength = 0;
            this.txtWeatherDescrip.SelectionStart = 0;
            this.txtWeatherDescrip.ShowClearButton = true;
            this.txtWeatherDescrip.Size = new System.Drawing.Size(305, 98);
            this.txtWeatherDescrip.TabIndex = 3;
            this.txtWeatherDescrip.UseSelectable = true;
            this.txtWeatherDescrip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWeatherDescrip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(5, 91);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(5);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(76, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Descripción";
            // 
            // txtWeather
            // 
            this.txtWeather.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWeather.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtWeather.CustomButton.Image = null;
            this.txtWeather.CustomButton.Location = new System.Drawing.Point(277, 2);
            this.txtWeather.CustomButton.Name = "";
            this.txtWeather.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtWeather.CustomButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.txtWeather.CustomButton.TabIndex = 1;
            this.txtWeather.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWeather.CustomButton.UseSelectable = true;
            this.txtWeather.CustomButton.Visible = false;
            this.txtWeather.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtWeather.Lines = new string[] {
        "Colima"};
            this.txtWeather.Location = new System.Drawing.Point(5, 46);
            this.txtWeather.Margin = new System.Windows.Forms.Padding(5, 0, 5, 3);
            this.txtWeather.MaxLength = 32767;
            this.txtWeather.Name = "txtWeather";
            this.txtWeather.PasswordChar = '\0';
            this.txtWeather.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeather.SelectedText = "";
            this.txtWeather.SelectionLength = 0;
            this.txtWeather.SelectionStart = 0;
            this.txtWeather.ShowClearButton = true;
            this.txtWeather.Size = new System.Drawing.Size(305, 30);
            this.txtWeather.TabIndex = 1;
            this.txtWeather.Text = "Colima";
            this.txtWeather.UseSelectable = true;
            this.txtWeather.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWeather.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(5, 22);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(5);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(124, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Municipio o Ciudad";
            // 
            // pnlBtns
            // 
            this.pnlBtns.AutoSize = true;
            this.pnlBtns.Controls.Add(this.btnOk);
            this.pnlBtns.Controls.Add(this.btnClean);
            this.pnlBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBtns.Location = new System.Drawing.Point(3, 228);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(315, 29);
            this.pnlBtns.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(161, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Agregar";
            this.metroToolTip1.SetToolTip(this.btnOk, "Agregar municipio o ciudad a la lista");
            this.btnOk.UseSelectable = true;
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClean.Location = new System.Drawing.Point(242, 3);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 0;
            this.btnClean.Text = "Limpiar";
            this.metroToolTip1.SetToolTip(this.btnClean, "Limpiar formulario");
            this.btnClean.UseSelectable = true;
            // 
            // gdWeathers
            // 
            this.gdWeathers.AllowUserToAddRows = false;
            this.gdWeathers.AllowUserToDeleteRows = false;
            this.gdWeathers.AllowUserToResizeRows = false;
            this.gdWeathers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdWeathers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdWeathers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gdWeathers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdWeathers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdWeathers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdWeathers.DefaultCellStyle = dataGridViewCellStyle2;
            this.gdWeathers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdWeathers.EnableHeadersVisualStyles = false;
            this.gdWeathers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gdWeathers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdWeathers.Location = new System.Drawing.Point(0, 0);
            this.gdWeathers.Name = "gdWeathers";
            this.gdWeathers.ReadOnly = true;
            this.gdWeathers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdWeathers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gdWeathers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gdWeathers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdWeathers.Size = new System.Drawing.Size(315, 260);
            this.gdWeathers.TabIndex = 1;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.metroTabPage1);
            this.tabCtrl.Controls.Add(this.metroTabPage2);
            this.tabCtrl.Controls.Add(this.metroTabPage3);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.Location = new System.Drawing.Point(20, 60);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(762, 320);
            this.tabCtrl.Style = MetroFramework.MetroColorStyle.Silver;
            this.tabCtrl.TabIndex = 0;
            this.tabCtrl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel1);
            this.metroTabPage1.Controls.Add(this.metroPanel2);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(754, 278);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Toma de Turnos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblTurno2Atiende, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblVentanilla2Atiende, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblServicio2Atiende, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTurno1Atiende, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblVentanilla1Atiende, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblServicio1Atiende, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 115);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 160);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblTurno2Atiende
            // 
            this.lblTurno2Atiende.AutoSize = true;
            this.lblTurno2Atiende.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTurno2Atiende.Location = new System.Drawing.Point(5, 94);
            this.lblTurno2Atiende.Name = "lblTurno2Atiende";
            this.lblTurno2Atiende.Size = new System.Drawing.Size(47, 64);
            this.lblTurno2Atiende.TabIndex = 14;
            this.lblTurno2Atiende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVentanilla2Atiende
            // 
            this.lblVentanilla2Atiende.AutoSize = true;
            this.lblVentanilla2Atiende.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVentanilla2Atiende.Location = new System.Drawing.Point(60, 94);
            this.lblVentanilla2Atiende.Name = "lblVentanilla2Atiende";
            this.lblVentanilla2Atiende.Size = new System.Drawing.Size(74, 64);
            this.lblVentanilla2Atiende.TabIndex = 15;
            this.lblVentanilla2Atiende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServicio2Atiende
            // 
            this.lblServicio2Atiende.AutoSize = true;
            this.lblServicio2Atiende.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServicio2Atiende.Location = new System.Drawing.Point(142, 94);
            this.lblServicio2Atiende.Name = "lblServicio2Atiende";
            this.lblServicio2Atiende.Size = new System.Drawing.Size(587, 64);
            this.lblServicio2Atiende.TabIndex = 16;
            this.lblServicio2Atiende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(5, 5);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Turno";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(60, 2);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 25);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Ventanilla";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(142, 2);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(587, 25);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Servicio";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurno1Atiende
            // 
            this.lblTurno1Atiende.AutoSize = true;
            this.lblTurno1Atiende.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTurno1Atiende.Location = new System.Drawing.Point(5, 29);
            this.lblTurno1Atiende.Name = "lblTurno1Atiende";
            this.lblTurno1Atiende.Size = new System.Drawing.Size(47, 63);
            this.lblTurno1Atiende.TabIndex = 11;
            this.lblTurno1Atiende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVentanilla1Atiende
            // 
            this.lblVentanilla1Atiende.AutoSize = true;
            this.lblVentanilla1Atiende.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVentanilla1Atiende.Location = new System.Drawing.Point(60, 29);
            this.lblVentanilla1Atiende.Name = "lblVentanilla1Atiende";
            this.lblVentanilla1Atiende.Size = new System.Drawing.Size(74, 63);
            this.lblVentanilla1Atiende.TabIndex = 12;
            this.lblVentanilla1Atiende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServicio1Atiende
            // 
            this.lblServicio1Atiende.AutoSize = true;
            this.lblServicio1Atiende.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServicio1Atiende.Location = new System.Drawing.Point(142, 29);
            this.lblServicio1Atiende.Name = "lblServicio1Atiende";
            this.lblServicio1Atiende.Size = new System.Drawing.Size(587, 63);
            this.lblServicio1Atiende.TabIndex = 13;
            this.lblServicio1Atiende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.lblVentanillaActual);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.lblTurnoActual);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(305, 10);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(439, 92);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // lblTurnoActual
            // 
            this.lblTurnoActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTurnoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoActual.ForeColor = System.Drawing.Color.Red;
            this.lblTurnoActual.Location = new System.Drawing.Point(321, 14);
            this.lblTurnoActual.Name = "lblTurnoActual";
            this.lblTurnoActual.Size = new System.Drawing.Size(112, 61);
            this.lblTurnoActual.TabIndex = 8;
            this.lblTurnoActual.Text = "1";
            this.lblTurnoActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.btnTurnoSiguiente);
            this.metroPanel1.Controls.Add(this.cbmVentanillas);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(10, 10);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(286, 92);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 2);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Ventanillas";
            // 
            // btnTurnoSiguiente
            // 
            this.btnTurnoSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTurnoSiguiente.Location = new System.Drawing.Point(128, 61);
            this.btnTurnoSiguiente.Margin = new System.Windows.Forms.Padding(5);
            this.btnTurnoSiguiente.Name = "btnTurnoSiguiente";
            this.btnTurnoSiguiente.Size = new System.Drawing.Size(151, 23);
            this.btnTurnoSiguiente.TabIndex = 5;
            this.btnTurnoSiguiente.Text = "Tomar siguiente turno";
            this.btnTurnoSiguiente.UseSelectable = true;
            // 
            // cbmVentanillas
            // 
            this.cbmVentanillas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbmVentanillas.FormattingEnabled = true;
            this.cbmVentanillas.ItemHeight = 23;
            this.cbmVentanillas.Location = new System.Drawing.Point(5, 23);
            this.cbmVentanillas.Margin = new System.Windows.Forms.Padding(5);
            this.cbmVentanillas.Name = "cbmVentanillas";
            this.cbmVentanillas.Size = new System.Drawing.Size(274, 29);
            this.cbmVentanillas.TabIndex = 4;
            this.cbmVentanillas.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage2.Controls.Add(this.tableLayoutPanel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(652, 278);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Administración de videos";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(652, 278);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage3.Controls.Add(this.splitContainer1);
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(652, 278);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Administracón de Clima";
            // 
            // metroContextMenu
            // 
            this.metroContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.metroContextMenu.Name = "metroContextMenu1";
            this.metroContextMenu.Size = new System.Drawing.Size(144, 54);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 6);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(751, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroStyleExtender1.SetApplyMetroTheme(this.pictureBox1, true);
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::turnosAdministrator.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(286, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.metroToolTip1.SetToolTip(this.pictureBox1, "Nuevo municipio o ciudad");
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.fileToolStripMenuItem.Text = "Cerrar Sesión";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitToolStripMenuItem.Image = global::turnosAdministrator.Properties.Resources.close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Cerrar";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblVentanillaActual
            // 
            this.lblVentanillaActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVentanillaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentanillaActual.ForeColor = System.Drawing.Color.Black;
            this.lblVentanillaActual.Location = new System.Drawing.Point(3, 25);
            this.lblVentanillaActual.Name = "lblVentanillaActual";
            this.lblVentanillaActual.Size = new System.Drawing.Size(312, 60);
            this.lblVentanillaActual.TabIndex = 10;
            this.lblVentanillaActual.Text = "Ventanilla B";
            this.lblVentanillaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 3);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(77, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "Atendiendo";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(301, 3);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Turno";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 400);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabCtrl);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "frmMain";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Pánel de configuración";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdWeathers)).EndInit();
            this.tabCtrl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroTabControl tabCtrl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.TabPage metroTabPage3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnTurnoSiguiente;
        private MetroFramework.Controls.MetroComboBox cbmVentanillas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel lblTurno2Atiende;
        private MetroFramework.Controls.MetroLabel lblVentanilla2Atiende;
        private MetroFramework.Controls.MetroLabel lblServicio2Atiende;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblTurno1Atiende;
        private MetroFramework.Controls.MetroLabel lblVentanilla1Atiende;
        private MetroFramework.Controls.MetroLabel lblServicio1Atiende;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Label lblTurnoActual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtWeatherDescrip;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtWeather;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Panel pnlBtns;
        private MetroFramework.Controls.MetroButton btnOk;
        private MetroFramework.Controls.MetroButton btnClean;
        private MetroFramework.Controls.MetroGrid gdWeathers;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label lblVentanillaActual;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}

