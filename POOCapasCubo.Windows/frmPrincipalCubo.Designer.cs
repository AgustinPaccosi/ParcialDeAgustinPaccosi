namespace POOCapasCubo.Windows
{
    partial class frmPrincipalCubo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalCubo));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.NuevoButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarButton = new System.Windows.Forms.ToolStripButton();
            this.EditarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ascendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ColoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorestoolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.RefrescarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CubosdataGridView = new System.Windows.Forms.DataGridView();
            this.ColArista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVolumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContadortextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CubosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoButton,
            this.BorrarButton,
            this.EditarButton,
            this.toolStripSeparator1,
            this.toolStripSeparator5,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.RefrescarButton,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.SalirButton,
            this.toolStripSeparator4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1016, 27);
            this.toolStrip2.TabIndex = 15;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // NuevoButton
            // 
            this.NuevoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(56, 24);
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click_1);
            // 
            // BorrarButton
            // 
            this.BorrarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(54, 24);
            this.BorrarButton.Text = "Borrar";
            this.BorrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(52, 24);
            this.EditarButton.Text = "Editar";
            this.EditarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendenteToolStripMenuItem,
            this.descendenteToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(77, 24);
            this.toolStripDropDownButton1.Text = "Ordenar";
            // 
            // ascendenteToolStripMenuItem
            // 
            this.ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            this.ascendenteToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.ascendenteToolStripMenuItem.Text = "Ascendente";
            this.ascendenteToolStripMenuItem.Click += new System.EventHandler(this.ascendenteToolStripMenuItem_Click);
            // 
            // descendenteToolStripMenuItem
            // 
            this.descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            this.descendenteToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.descendenteToolStripMenuItem.Text = "Descendente";
            this.descendenteToolStripMenuItem.Click += new System.EventHandler(this.descendenteToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColoresToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(61, 24);
            this.toolStripDropDownButton2.Text = "Filtrar";
            // 
            // ColoresToolStripMenuItem
            // 
            this.ColoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorestoolStripComboBox});
            this.ColoresToolStripMenuItem.Name = "ColoresToolStripMenuItem";
            this.ColoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ColoresToolStripMenuItem.Text = "Colores";
            // 
            // ColorestoolStripComboBox
            // 
            this.ColorestoolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorestoolStripComboBox.Name = "ColorestoolStripComboBox";
            this.ColorestoolStripComboBox.Size = new System.Drawing.Size(121, 28);
            // 
            // RefrescarButton
            // 
            this.RefrescarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefrescarButton.Name = "RefrescarButton";
            this.RefrescarButton.Size = new System.Drawing.Size(75, 24);
            this.RefrescarButton.Text = "Restaurar";
            this.RefrescarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefrescarButton.Click += new System.EventHandler(this.RefrescarButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // SalirButton
            // 
            this.SalirButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(42, 24);
            this.SalirButton.Text = "Salir";
            this.SalirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CubosdataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ContadortextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1016, 534);
            this.splitContainer1.SplitterDistance = 419;
            this.splitContainer1.TabIndex = 17;
            // 
            // CubosdataGridView
            // 
            this.CubosdataGridView.AllowUserToAddRows = false;
            this.CubosdataGridView.AllowUserToDeleteRows = false;
            this.CubosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CubosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColArista,
            this.ColColor,
            this.ColTrazo,
            this.ColArea,
            this.ColVolumen});
            this.CubosdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CubosdataGridView.Location = new System.Drawing.Point(0, 0);
            this.CubosdataGridView.Name = "CubosdataGridView";
            this.CubosdataGridView.ReadOnly = true;
            this.CubosdataGridView.RowHeadersWidth = 51;
            this.CubosdataGridView.RowTemplate.Height = 24;
            this.CubosdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CubosdataGridView.Size = new System.Drawing.Size(1016, 419);
            this.CubosdataGridView.TabIndex = 0;
            // 
            // ColArista
            // 
            this.ColArista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColArista.HeaderText = "Arista";
            this.ColArista.MinimumWidth = 6;
            this.ColArista.Name = "ColArista";
            this.ColArista.ReadOnly = true;
            // 
            // ColColor
            // 
            this.ColColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColColor.HeaderText = "Color";
            this.ColColor.MinimumWidth = 6;
            this.ColColor.Name = "ColColor";
            this.ColColor.ReadOnly = true;
            // 
            // ColTrazo
            // 
            this.ColTrazo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTrazo.HeaderText = "Trazo";
            this.ColTrazo.MinimumWidth = 6;
            this.ColTrazo.Name = "ColTrazo";
            this.ColTrazo.ReadOnly = true;
            // 
            // ColArea
            // 
            this.ColArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColArea.HeaderText = "Area";
            this.ColArea.MinimumWidth = 6;
            this.ColArea.Name = "ColArea";
            this.ColArea.ReadOnly = true;
            // 
            // ColVolumen
            // 
            this.ColVolumen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColVolumen.HeaderText = "Volumen";
            this.ColVolumen.MinimumWidth = 6;
            this.ColVolumen.Name = "ColVolumen";
            this.ColVolumen.ReadOnly = true;
            // 
            // ContadortextBox
            // 
            this.ContadortextBox.Enabled = false;
            this.ContadortextBox.Location = new System.Drawing.Point(185, 27);
            this.ContadortextBox.Name = "ContadortextBox";
            this.ContadortextBox.Size = new System.Drawing.Size(49, 22);
            this.ContadortextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad De Datos:";
            // 
            // frmPrincipalCubo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "frmPrincipalCubo";
            this.Text = "frmPrincipalCubo";
            this.Load += new System.EventHandler(this.frmPrincipalCubo_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CubosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton NuevoButton;
        private System.Windows.Forms.ToolStripButton BorrarButton;
        private System.Windows.Forms.ToolStripButton EditarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RefrescarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton SalirButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView CubosdataGridView;
        private System.Windows.Forms.TextBox ContadortextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVolumen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ascendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem ColoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ColorestoolStripComboBox;
    }
}