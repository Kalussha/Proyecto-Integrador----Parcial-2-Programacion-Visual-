namespace Proyecto_Unidad_1_Programacion_Visual
{
    partial class frmconsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconsultar));
            lblconsultaplaca = new Label();
            txtplacaconsultar = new TextBox();
            txtmarca = new TextBox();
            txtmodelo = new TextBox();
            txtaño = new TextBox();
            txttipo = new TextBox();
            lblmarcaconsulta = new Label();
            lblmodeloconsulta = new Label();
            lblañoconsulta = new Label();
            lbltipo = new Label();
            btnconsultar = new Button();
            btnconsultarregresar = new Button();
            SuspendLayout();
            // 
            // lblconsultaplaca
            // 
            lblconsultaplaca.AutoSize = true;
            lblconsultaplaca.Location = new Point(43, 55);
            lblconsultaplaca.Name = "lblconsultaplaca";
            lblconsultaplaca.Size = new Size(47, 15);
            lblconsultaplaca.TabIndex = 0;
            lblconsultaplaca.Text = "PLACA:";
            // 
            // txtplacaconsultar
            // 
            txtplacaconsultar.Location = new Point(110, 51);
            txtplacaconsultar.Name = "txtplacaconsultar";
            txtplacaconsultar.Size = new Size(100, 23);
            txtplacaconsultar.TabIndex = 1;
            txtplacaconsultar.TextChanged += txtplacaconsultar_TextChanged;
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(110, 102);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(100, 23);
            txtmarca.TabIndex = 2;
            txtmarca.TextChanged += txtmarca_TextChanged;
            // 
            // txtmodelo
            // 
            txtmodelo.Location = new Point(110, 149);
            txtmodelo.Name = "txtmodelo";
            txtmodelo.Size = new Size(100, 23);
            txtmodelo.TabIndex = 3;
            txtmodelo.TextChanged += txtmodelo_TextChanged;
            // 
            // txtaño
            // 
            txtaño.Location = new Point(110, 199);
            txtaño.Name = "txtaño";
            txtaño.Size = new Size(100, 23);
            txtaño.TabIndex = 4;
            txtaño.TextChanged += txtaño_TextChanged;
            // 
            // txttipo
            // 
            txttipo.Location = new Point(110, 256);
            txttipo.Name = "txttipo";
            txttipo.Size = new Size(100, 23);
            txttipo.TabIndex = 5;
            txttipo.TextChanged += txttipo_TextChanged;
            // 
            // lblmarcaconsulta
            // 
            lblmarcaconsulta.AutoSize = true;
            lblmarcaconsulta.Location = new Point(36, 105);
            lblmarcaconsulta.Name = "lblmarcaconsulta";
            lblmarcaconsulta.Size = new Size(52, 15);
            lblmarcaconsulta.TabIndex = 6;
            lblmarcaconsulta.Text = "MARCA:";
            // 
            // lblmodeloconsulta
            // 
            lblmodeloconsulta.AutoSize = true;
            lblmodeloconsulta.Location = new Point(36, 152);
            lblmodeloconsulta.Name = "lblmodeloconsulta";
            lblmodeloconsulta.Size = new Size(59, 15);
            lblmodeloconsulta.TabIndex = 7;
            lblmodeloconsulta.Text = "MODELO:";
            // 
            // lblañoconsulta
            // 
            lblañoconsulta.AutoSize = true;
            lblañoconsulta.Location = new Point(43, 202);
            lblañoconsulta.Name = "lblañoconsulta";
            lblañoconsulta.Size = new Size(36, 15);
            lblañoconsulta.TabIndex = 8;
            lblañoconsulta.Text = "AÑO:";
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.Location = new Point(43, 259);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(35, 15);
            lbltipo.TabIndex = 9;
            lbltipo.Text = "TIPO:";
            // 
            // btnconsultar
            // 
            btnconsultar.Location = new Point(256, 51);
            btnconsultar.Name = "btnconsultar";
            btnconsultar.Size = new Size(82, 23);
            btnconsultar.TabIndex = 10;
            btnconsultar.Text = "CONSULTAR";
            btnconsultar.UseVisualStyleBackColor = true;
            btnconsultar.Click += btnconsultar_Click;
            // 
            // btnconsultarregresar
            // 
            btnconsultarregresar.Location = new Point(338, 376);
            btnconsultarregresar.Name = "btnconsultarregresar";
            btnconsultarregresar.Size = new Size(97, 23);
            btnconsultarregresar.TabIndex = 11;
            btnconsultarregresar.Text = "<-REGRESAR";
            btnconsultarregresar.UseVisualStyleBackColor = true;
            btnconsultarregresar.Click += btnconsultarregresar_Click;
            // 
            // frmconsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnconsultarregresar);
            Controls.Add(btnconsultar);
            Controls.Add(lbltipo);
            Controls.Add(lblañoconsulta);
            Controls.Add(lblmodeloconsulta);
            Controls.Add(lblmarcaconsulta);
            Controls.Add(txttipo);
            Controls.Add(txtaño);
            Controls.Add(txtmodelo);
            Controls.Add(txtmarca);
            Controls.Add(txtplacaconsultar);
            Controls.Add(lblconsultaplaca);
            Name = "frmconsultar";
            Text = "frmconsultar";
            Load += frmconsultar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblconsultaplaca;
        private TextBox txtplacaconsultar;
        private TextBox txtmarca;
        private TextBox txtmodelo;
        private TextBox txtaño;
        private TextBox txttipo;
        private Label lblmarcaconsulta;
        private Label lblmodeloconsulta;
        private Label lblañoconsulta;
        private Label lbltipo;
        private Button btnconsultar;
        private Button btnconsultarregresar;
    }
}