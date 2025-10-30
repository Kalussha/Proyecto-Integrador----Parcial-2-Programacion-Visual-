namespace Proyecto_Unidad_1_Programacion_Visual
{
    partial class frminicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminicio));
            btnconsultar = new Button();
            btnalta = new Button();
            btnbaja = new Button();
            btncambios = new Button();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // btnconsultar
            // 
            btnconsultar.Location = new Point(198, 362);
            btnconsultar.Name = "btnconsultar";
            btnconsultar.Size = new Size(75, 23);
            btnconsultar.TabIndex = 0;
            btnconsultar.Text = "CONSULTAR";
            btnconsultar.UseVisualStyleBackColor = true;
            btnconsultar.Click += btnconsultar_Click;
            // 
            // btnalta
            // 
            btnalta.Location = new Point(305, 362);
            btnalta.Name = "btnalta";
            btnalta.Size = new Size(75, 23);
            btnalta.TabIndex = 1;
            btnalta.Text = "ALTA";
            btnalta.UseVisualStyleBackColor = true;
            btnalta.Click += btnalta_Click;
            // 
            // btnbaja
            // 
            btnbaja.Location = new Point(421, 362);
            btnbaja.Name = "btnbaja";
            btnbaja.Size = new Size(75, 23);
            btnbaja.TabIndex = 2;
            btnbaja.Text = "BAJA";
            btnbaja.UseVisualStyleBackColor = true;
            btnbaja.Click += btnbaja_Click;
            // 
            // btncambios
            // 
            btncambios.Location = new Point(538, 362);
            btncambios.Name = "btncambios";
            btncambios.Size = new Size(75, 23);
            btncambios.TabIndex = 3;
            btncambios.Text = "CAMBIOS";
            btncambios.UseVisualStyleBackColor = true;
            btncambios.Click += btncambios_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(305, 406);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(191, 32);
            btnsalir.TabIndex = 4;
            btnsalir.Text = "SALIR Y CERRAR SESION";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // frminicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsalir);
            Controls.Add(btncambios);
            Controls.Add(btnbaja);
            Controls.Add(btnalta);
            Controls.Add(btnconsultar);
            Name = "frminicio";
            Text = "INICIO";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnconsultar;
        private Button btnalta;
        private Button btnbaja;
        private Button btncambios;
        private Button btnsalir;
    }
}
