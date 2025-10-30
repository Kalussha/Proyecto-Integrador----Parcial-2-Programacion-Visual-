using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Unidad_1_Programacion_Visual
{
    // form de alta, aqui registras coches nuevos en la base de datos
    public partial class frmalta : Form
    {
        // constructor basico, nada raro
        public frmalta()
        {
            InitializeComponent();
        }

        // cuando carga el form llena el combo con los años
        // desde el año actual hasta 45 años atras
        private void frmalta_Load(object sender, EventArgs e)
        {
            int anioActual = DateTime.Now.Year; // agarramos el año actual
            for (int i = 0; i < 46; i++) 
            {
                cmbaño.Items.Add((anioActual - i).ToString()); // vamos restando años
            }
            cmbaño.SelectedIndex = 0; // dejamos seleccionado el año actual por defecto
        }

        // el boton importante, aqui se guarda el coche nuevo
        private void btnguardar_Click(object sender, EventArgs e)
        {
            // validaciones basicas, todos los campos tienen que tener algo
            // no queremos datos incompletos en la base
            if (string.IsNullOrWhiteSpace(txtplaca.Text) ||
                string.IsNullOrWhiteSpace(txtmarca.Text) ||
                string.IsNullOrWhiteSpace(txtmodelo.Text) ||
                cmbaño.SelectedIndex == -1 ||
                (!rdbtnsuv.Checked && !rdbtnpickup.Checked && !rdbtnsedan.Checked))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // salimos si falta algo
            }

            try
            {
                // creamos el objeto Coche con los datos del formulario
                Coche nuevoCoche = new Coche
                {
                    Placa = txtplaca.Text.Trim().ToUpper(), // placa en mayusculas siempre
                    Marca = txtmarca.Text.Trim(),
                    Modelo = txtmodelo.Text.Trim(),
                    Anio = int.Parse(cmbaño.SelectedItem.ToString()), // convertimos el string a int
                    Tipo = rdbtnsuv.Checked ? "SUV" :
                           rdbtnpickup.Checked ? "PICK UP" : "SEDAN"
                };

                // mandamos a insertar en la base de datos usando el DAO
                bool resultado = CocheDAO.InsertarCoche(nuevoCoche);

                if (resultado)
                {
                    // todo salio bien, limpiamos el form pa registrar otro si quiere
                    MessageBox.Show("Vehículo registrado correctamente en la base de datos.", "Éxito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    // algo salio mal, no se pudo guardar
                    MessageBox.Show("No se pudo registrar el vehículo.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // si truena algo mostramos el error
                // puede ser placa duplicada o problemas de conexion
                MessageBox.Show(ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // metodo auxiliar para limpiar todo el formulario
        // lo dejamos listo para registrar otro coche
        private void LimpiarFormulario()
        {
            txtplaca.Clear();
            txtmarca.Clear();
            txtmodelo.Clear();
            cmbaño.SelectedIndex = 0; // volvemos al año actual
            rdbtnsuv.Checked = false;
            rdbtnpickup.Checked = false;
            rdbtnsedan.Checked = false;
            txtplaca.Focus(); // ponemos el cursor en la placa pa empezar rapido
        }
    }
}
