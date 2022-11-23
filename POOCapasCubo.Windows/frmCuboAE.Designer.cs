namespace POOCapasCubo.Windows
{
    partial class frmCuboAE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AristatextBox = new System.Windows.Forms.TextBox();
            this.ColorcomboBox = new System.Windows.Forms.ComboBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.ErrorerrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RayasradioButton = new System.Windows.Forms.RadioButton();
            this.ContinuoradioButton = new System.Windows.Forms.RadioButton();
            this.PuntosradioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorerrorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medida De la Arista:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Color De Cubo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trazo Del Cubo:";
            // 
            // AristatextBox
            // 
            this.AristatextBox.Location = new System.Drawing.Point(171, 30);
            this.AristatextBox.Name = "AristatextBox";
            this.AristatextBox.Size = new System.Drawing.Size(140, 22);
            this.AristatextBox.TabIndex = 1;
            // 
            // ColorcomboBox
            // 
            this.ColorcomboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorcomboBox.FormattingEnabled = true;
            this.ColorcomboBox.Location = new System.Drawing.Point(171, 67);
            this.ColorcomboBox.Name = "ColorcomboBox";
            this.ColorcomboBox.Size = new System.Drawing.Size(140, 24);
            this.ColorcomboBox.TabIndex = 2;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(40, 229);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(107, 105);
            this.OKbutton.TabIndex = 4;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(204, 229);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(107, 105);
            this.Cancelbutton.TabIndex = 4;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // ErrorerrorProvider1
            // 
            this.ErrorerrorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PuntosradioButton);
            this.groupBox1.Controls.Add(this.RayasradioButton);
            this.groupBox1.Controls.Add(this.ContinuoradioButton);
            this.groupBox1.Location = new System.Drawing.Point(171, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // RayasradioButton
            // 
            this.RayasradioButton.AutoSize = true;
            this.RayasradioButton.Location = new System.Drawing.Point(6, 36);
            this.RayasradioButton.Name = "RayasradioButton";
            this.RayasradioButton.Size = new System.Drawing.Size(129, 21);
            this.RayasradioButton.TabIndex = 0;
            this.RayasradioButton.TabStop = true;
            this.RayasradioButton.Text = "Rayas     --------";
            this.RayasradioButton.UseVisualStyleBackColor = true;
            // 
            // ContinuoradioButton
            // 
            this.ContinuoradioButton.AutoSize = true;
            this.ContinuoradioButton.Location = new System.Drawing.Point(6, 9);
            this.ContinuoradioButton.Name = "ContinuoradioButton";
            this.ContinuoradioButton.Size = new System.Drawing.Size(137, 21);
            this.ContinuoradioButton.TabIndex = 0;
            this.ContinuoradioButton.TabStop = true;
            this.ContinuoradioButton.Text = "Continuo ______";
            this.ContinuoradioButton.UseVisualStyleBackColor = true;
            // 
            // PuntosradioButton
            // 
            this.PuntosradioButton.AutoSize = true;
            this.PuntosradioButton.Location = new System.Drawing.Point(6, 63);
            this.PuntosradioButton.Name = "PuntosradioButton";
            this.PuntosradioButton.Size = new System.Drawing.Size(129, 21);
            this.PuntosradioButton.TabIndex = 0;
            this.PuntosradioButton.TabStop = true;
            this.PuntosradioButton.Text = "Puntos   ...........";
            this.PuntosradioButton.UseVisualStyleBackColor = true;
            // 
            // frmCuboAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.ColorcomboBox);
            this.Controls.Add(this.AristatextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(440, 420);
            this.MinimumSize = new System.Drawing.Size(440, 420);
            this.Name = "frmCuboAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCuboAE";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorerrorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AristatextBox;
        private System.Windows.Forms.ComboBox ColorcomboBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.ErrorProvider ErrorerrorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RayasradioButton;
        private System.Windows.Forms.RadioButton ContinuoradioButton;
        private System.Windows.Forms.RadioButton PuntosradioButton;
    }
}