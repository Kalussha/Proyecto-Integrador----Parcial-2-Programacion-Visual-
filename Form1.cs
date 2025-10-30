namespace Proyecto_Unidad_1_Programacion_Visual
{
    // este es el form principal, el que se ve primero cuando arrancas el programa
    public partial class frminicio : Form
    {
        // aqui se inicializa todo
        public frminicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // cuando le das al boton de alta se abre ese form y este se esconde
        private void btnalta_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            frmalta frm = new frmalta();
            frm.FormClosed += (s, args) => this.Show(); 
            frm.Show();
        }

        // mismo rollo que el de arriba pero con el form de baja
        private void btnbaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmbaja frm = new frmbaja();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        // y aqui el de cambios, mismo copy paste del de arriba
        private void btncambios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcambios frm = new frmcambios();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        // para consultar los coches, otra vez lo mismo
        private void btnconsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmconsultar frm = new frmconsultar();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        // boton para salir de la aplicacion completamente
        private void btnsalir_Click(object sender, EventArgs e)
        {   
            Application.Exit();

        }
    }
}
