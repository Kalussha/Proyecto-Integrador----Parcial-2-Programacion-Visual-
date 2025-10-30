namespace Proyecto_Unidad_1_Programacion_Visual
{
    partial class frmalta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmalta));
            txtplaca = new TextBox();
            lblplacas = new Label();
            lblmarca = new Label();
            txtmarca = new TextBox();
            lblmodelo = new Label();
            txtmodelo = new TextBox();
            lblaño = new Label();
            cmbaño = new ComboBox();
            btnguardar = new Button();
            gpotipo = new GroupBox();
            rdbtnsedan = new RadioButton();
            rdbtnpickup = new RadioButton();
            rdbtnsuv = new RadioButton();
            gpotipo.SuspendLayout();
            SuspendLayout();
            // 
            // txtplaca
            // 
            txtplaca.Location = new Point(89, 57);
            txtplaca.Name = "txtplaca";
            txtplaca.Size = new Size(121, 23);
            txtplaca.TabIndex = 0;

            // 
            // lblplacas
            // 
            lblplacas.AutoSize = true;
            lblplacas.Location = new Point(24, 60);
            lblplacas.Name = "lblplacas";
            lblplacas.Size = new Size(53, 15);
            lblplacas.TabIndex = 1;
            lblplacas.Text = "PLACAS:";
            // 
            // lblmarca
            // 
            lblmarca.AutoSize = true;
            lblmarca.Location = new Point(24, 98);
            lblmarca.Name = "lblmarca";
            lblmarca.Size = new Size(52, 15);
            lblmarca.TabIndex = 3;
            lblmarca.Text = "MARCA:";
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(89, 95);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(121, 23);
            txtmarca.TabIndex = 2;
            // 
            // lblmodelo
            // 
            lblmodelo.AutoSize = true;
            lblmodelo.Location = new Point(24, 139);
            lblmodelo.Name = "lblmodelo";
            lblmodelo.Size = new Size(59, 15);
            lblmodelo.TabIndex = 5;
            lblmodelo.Text = "MODELO:";
            // 
            // txtmodelo
            // 
            txtmodelo.Location = new Point(89, 136);
            txtmodelo.Name = "txtmodelo";
            txtmodelo.Size = new Size(121, 23);
            txtmodelo.TabIndex = 4;
            // 
            // lblaño
            // 
            lblaño.AutoSize = true;
            lblaño.Location = new Point(24, 183);
            lblaño.Name = "lblaño";
            lblaño.Size = new Size(36, 15);
            lblaño.TabIndex = 6;
            lblaño.Text = "AÑO:";
            // 
            // cmbaño
            // 
            cmbaño.FormattingEnabled = true;
            cmbaño.Location = new Point(89, 180);
            cmbaño.Name = "cmbaño";
            cmbaño.Size = new Size(121, 23);
            cmbaño.TabIndex = 7;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(189, 388);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(95, 23);
            btnguardar.TabIndex = 8;
            btnguardar.Text = "Guardar y salir";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // gpotipo
            // 
            gpotipo.Controls.Add(rdbtnsedan);
            gpotipo.Controls.Add(rdbtnpickup);
            gpotipo.Controls.Add(rdbtnsuv);
            gpotipo.Location = new Point(24, 218);
            gpotipo.Name = "gpotipo";
            gpotipo.Size = new Size(200, 100);
            gpotipo.TabIndex = 9;
            gpotipo.TabStop = false;
            gpotipo.Text = "TIPO";
            // 
            // rdbtnsedan
            // 
            rdbtnsedan.AutoSize = true;
            rdbtnsedan.Location = new Point(6, 72);
            rdbtnsedan.Name = "rdbtnsedan";
            rdbtnsedan.Size = new Size(62, 19);
            rdbtnsedan.TabIndex = 2;
            rdbtnsedan.TabStop = true;
            rdbtnsedan.Text = "SEDAN";
            rdbtnsedan.UseVisualStyleBackColor = true;
            // 
            // rdbtnpickup
            // 
            rdbtnpickup.AutoSize = true;
            rdbtnpickup.Location = new Point(6, 47);
            rdbtnpickup.Name = "rdbtnpickup";
            rdbtnpickup.Size = new Size(71, 19);
            rdbtnpickup.TabIndex = 1;
            rdbtnpickup.TabStop = true;
            rdbtnpickup.Text = "PICK UP ";
            rdbtnpickup.UseVisualStyleBackColor = true;
            // 
            // rdbtnsuv
            // 
            rdbtnsuv.AutoSize = true;
            rdbtnsuv.Location = new Point(6, 22);
            rdbtnsuv.Name = "rdbtnsuv";
            rdbtnsuv.Size = new Size(118, 19);
            rdbtnsuv.TabIndex = 0;
            rdbtnsuv.TabStop = true;
            rdbtnsuv.Text = "SUV/CAMIONETA";
            rdbtnsuv.UseVisualStyleBackColor = true;
            // 
            // frmalta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(gpotipo);
            Controls.Add(btnguardar);
            Controls.Add(cmbaño);
            Controls.Add(lblaño);
            Controls.Add(lblmodelo);
            Controls.Add(txtmodelo);
            Controls.Add(lblmarca);
            Controls.Add(txtmarca);
            Controls.Add(lblplacas);
            Controls.Add(txtplaca);
            Name = "frmalta";
            Text = "Alta";
            Load += frmalta_Load;
            gpotipo.ResumeLayout(false);
            gpotipo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtplaca;
        private Label lblplacas;
        private Label lblmarca;
        private TextBox txtmarca;
        private Label lblmodelo;
        private TextBox txtmodelo;
        private Label lblaño;
        private ComboBox cmbaño;
        private Button btnguardar;
        private GroupBox gpotipo;
        private RadioButton rdbtnsedan;
        private RadioButton rdbtnpickup;
        private RadioButton rdbtnsuv;
    }
}