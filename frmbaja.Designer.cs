namespace Proyecto_Unidad_1_Programacion_Visual
{
    partial class frmbaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbaja));
            lblplacabaja = new Label();
            txtbajaplaca = new TextBox();
            btnbajaeliminar = new Button();
            SuspendLayout();
            // 
            // lblplacabaja
            // 
            lblplacabaja.AutoSize = true;
            lblplacabaja.Location = new Point(32, 49);
            lblplacabaja.Name = "lblplacabaja";
            lblplacabaja.Size = new Size(132, 15);
            lblplacabaja.TabIndex = 0;
            lblplacabaja.Text = "PLACA A DAR DE BAJA:";
            // 
            // txtbajaplaca
            // 
            txtbajaplaca.Location = new Point(186, 46);
            txtbajaplaca.Name = "txtbajaplaca";
            txtbajaplaca.Size = new Size(100, 23);
            txtbajaplaca.TabIndex = 1;
            txtbajaplaca.TextChanged += txtbajaplaca_TextChanged;
            // 
            // btnbajaeliminar
            // 
            btnbajaeliminar.Location = new Point(356, 381);
            btnbajaeliminar.Name = "btnbajaeliminar";
            btnbajaeliminar.Size = new Size(75, 23);
            btnbajaeliminar.TabIndex = 2;
            btnbajaeliminar.Text = "ELIMINAR";
            btnbajaeliminar.UseVisualStyleBackColor = true;
            btnbajaeliminar.Click += btnbajaeliminar_Click;
            // 
            // frmbaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnbajaeliminar);
            Controls.Add(txtbajaplaca);
            Controls.Add(lblplacabaja);
            Name = "frmbaja";
            Text = "frmbaja";
            Load += frmbaja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblplacabaja;
        private TextBox txtbajaplaca;
        private Button btnbajaeliminar;
    }
}