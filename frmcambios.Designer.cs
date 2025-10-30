namespace Proyecto_Unidad_1_Programacion_Visual
{
    partial class frmcambios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcambios));
            gpotipo = new GroupBox();
            rdbtnsedan = new RadioButton();
            rdbtnpickup = new RadioButton();
            rdbtnsuv = new RadioButton();
            lblaño = new Label();
            lblmodelo = new Label();
            txtmodelo = new TextBox();
            lblmarca = new Label();
            txtmarca = new TextBox();
            lblplacas = new Label();
            txtplaca = new TextBox();
            btnconsultacambio = new Button();
            btnguardarcambios = new Button();
            cbaño = new ComboBox();
            gpotipo.SuspendLayout();
            SuspendLayout();
            // 
            // gpotipo
            // 
            gpotipo.Controls.Add(rdbtnsedan);
            gpotipo.Controls.Add(rdbtnpickup);
            gpotipo.Controls.Add(rdbtnsuv);
            gpotipo.Location = new Point(19, 180);
            gpotipo.Name = "gpotipo";
            gpotipo.Size = new Size(200, 100);
            gpotipo.TabIndex = 18;
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
            // lblaño
            // 
            lblaño.AutoSize = true;
            lblaño.Location = new Point(19, 145);
            lblaño.Name = "lblaño";
            lblaño.Size = new Size(36, 15);
            lblaño.TabIndex = 16;
            lblaño.Text = "AÑO:";
            // 
            // lblmodelo
            // 
            lblmodelo.AutoSize = true;
            lblmodelo.Location = new Point(19, 101);
            lblmodelo.Name = "lblmodelo";
            lblmodelo.Size = new Size(59, 15);
            lblmodelo.TabIndex = 15;
            lblmodelo.Text = "MODELO:";
            // 
            // txtmodelo
            // 
            txtmodelo.Location = new Point(84, 98);
            txtmodelo.Name = "txtmodelo";
            txtmodelo.Size = new Size(121, 23);
            txtmodelo.TabIndex = 14;
            // 
            // lblmarca
            // 
            lblmarca.AutoSize = true;
            lblmarca.Location = new Point(19, 60);
            lblmarca.Name = "lblmarca";
            lblmarca.Size = new Size(52, 15);
            lblmarca.TabIndex = 13;
            lblmarca.Text = "MARCA:";
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(84, 57);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(121, 23);
            txtmarca.TabIndex = 12;
            // 
            // lblplacas
            // 
            lblplacas.AutoSize = true;
            lblplacas.Location = new Point(19, 22);
            lblplacas.Name = "lblplacas";
            lblplacas.Size = new Size(47, 15);
            lblplacas.TabIndex = 11;
            lblplacas.Text = "PLACA:";
            // 
            // txtplaca
            // 
            txtplaca.Location = new Point(84, 19);
            txtplaca.Name = "txtplaca";
            txtplaca.Size = new Size(121, 23);
            txtplaca.TabIndex = 10;
            // 
            // btnconsultacambio
            // 
            btnconsultacambio.Location = new Point(252, 18);
            btnconsultacambio.Name = "btnconsultacambio";
            btnconsultacambio.Size = new Size(75, 23);
            btnconsultacambio.TabIndex = 19;
            btnconsultacambio.Text = "CONSULTAR";
            btnconsultacambio.UseVisualStyleBackColor = true;
            btnconsultacambio.Click += btnconsultacambio_Click;
            // 
            // btnguardarcambios
            // 
            btnguardarcambios.Location = new Point(252, 252);
            btnguardarcambios.Name = "btnguardarcambios";
            btnguardarcambios.Size = new Size(131, 23);
            btnguardarcambios.TabIndex = 20;
            btnguardarcambios.Text = "GUARDAR CAMBIOS";
            btnguardarcambios.UseVisualStyleBackColor = true;
            btnguardarcambios.Click += btnguardarcambios_Click_1;
            // 
            // cbaño
            // 
            cbaño.FormattingEnabled = true;
            cbaño.Location = new Point(84, 142);
            cbaño.Name = "cbaño";
            cbaño.Size = new Size(121, 23);
            cbaño.TabIndex = 21;
            // 
            // frmcambios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(cbaño);
            Controls.Add(btnguardarcambios);
            Controls.Add(btnconsultacambio);
            Controls.Add(gpotipo);
            Controls.Add(lblaño);
            Controls.Add(lblmodelo);
            Controls.Add(txtmodelo);
            Controls.Add(lblmarca);
            Controls.Add(txtmarca);
            Controls.Add(lblplacas);
            Controls.Add(txtplaca);
            Name = "frmcambios";
            Text = "frmcambios";
            Load += frmcambios_Load;
            gpotipo.ResumeLayout(false);
            gpotipo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpotipo;
        private RadioButton rdbtnsedan;
        private RadioButton rdbtnpickup;
        private RadioButton rdbtnsuv;
        private Label lblaño;
        private Label lblmodelo;
        private TextBox txtmodelo;
        private Label lblmarca;
        private TextBox txtmarca;
        private Label lblplacas;
        private TextBox txtplaca;
        private Button btnconsultacambio;
        private Button btnguardarcambios;
        private ComboBox cbaño;
    }
}