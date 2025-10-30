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
    // form para editar coches, aqui cambias la info de los carros que ya estan registrados
    public partial class frmcambios : Form
    {
        // este coche guarda el que estas editando
        private Coche cocheEditando = null;

        // constructor basico
        public frmcambios()
        {
            InitializeComponent();
        }

        // cuando carga el form llena el combo de años
        // desde el año actual hasta 1980
        private void frmcambios_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox de años
            int anioActual = DateTime.Now.Year;
            cbaño.Items.Clear(); // limpiamos 
            for (int anio = anioActual; anio >= 1980; anio--)
            {
                cbaño.Items.Add(anio.ToString()); // metemos todos los años
            }
        }

        // aqui buscas el coche por placa y si existe lo cargas en los campos
        // importante: primero consultas, despues editas
        private void btnconsultacambio_Click(object sender, EventArgs e)
        {
            string placaBuscada = txtplaca.Text.Trim().ToUpper(); // todo en mayusculas pa evitar problemas

            // validacion basica
            if (string.IsNullOrWhiteSpace(placaBuscada))
            {
                MessageBox.Show("Por favor, ingrese una placa.", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // nos salimos si no hay nada
            }

            try
            {
                // buscamos en la base de datos usando el DAO
                cocheEditando = CocheDAO.ConsultarCochePorPlaca(placaBuscada);

                // si lo encontro lo mostramos en los campos
                if (cocheEditando != null)
                {
                    // Llenar los campos con los datos del coche
                    txtmarca.Text = cocheEditando.Marca;
                    txtmodelo.Text = cocheEditando.Modelo;
                    cbaño.SelectedItem = cocheEditando.Anio.ToString(); 

                    // marcamos el radio button que corresponda segun el tipo
                    rdbtnsuv.Checked = cocheEditando.Tipo == "SUV";
                    rdbtnpickup.Checked = cocheEditando.Tipo == "PICK UP";
                    rdbtnsedan.Checked = cocheEditando.Tipo == "SEDAN";

                    MessageBox.Show("Vehículo encontrado. Ahora puedes editar los datos.", "Éxito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // no existe ese coche
                    MessageBox.Show("Placa no encontrada en la base de datos.", "Información", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario(); // limpiamos todo
                }
            }
            catch (Exception ex)
            {
                // si truena mostramos el error
                MessageBox.Show(ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // aqui guardas los cambios que hiciste, el metodo importante
        private void btnguardarcambios_Click_1(object sender, EventArgs e)
        {
            // primero checamos que hayas consultado algo
            if (cocheEditando == null)
            {
                MessageBox.Show("Primero consulta una placa válida.", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // te sales si no has consultado nada
            }

            // validamos que todos los campos tengan algo
            // no queremos campos vacios en la base de datos
            if (string.IsNullOrWhiteSpace(txtmarca.Text) ||
                string.IsNullOrWhiteSpace(txtmodelo.Text) ||
                cbaño.SelectedIndex == -1 ||
                (!rdbtnsuv.Checked && !rdbtnpickup.Checked && !rdbtnsedan.Checked))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // actualizamos los datos del objeto con lo que escribiste
                cocheEditando.Marca = txtmarca.Text.Trim();
                cocheEditando.Modelo = txtmodelo.Text.Trim();
                cocheEditando.Anio = int.Parse(cbaño.SelectedItem.ToString());
                // operador ternario anidado
                cocheEditando.Tipo = rdbtnsuv.Checked ? "SUV" :
                                     rdbtnpickup.Checked ? "PICK UP" : "SEDAN";

                // mandamos a actualizar en la base de datos
                bool resultado = CocheDAO.ActualizarCoche(cocheEditando);

                if (resultado)
                {
                    // todo salio bien, cerramos el form
                    MessageBox.Show("Cambios guardados correctamente en la base de datos.", "Éxito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // bye bye
                }
                else
                {
                    // algo salio mal
                    MessageBox.Show("No se pudieron guardar los cambios.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // por si truena algo mostramos el error
                MessageBox.Show(ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // metodo auxiliar para limpiar todo el formulario
        // lo uso cuando no encuentra el coche
        private void LimpiarFormulario()
        {
            txtmarca.Clear();
            txtmodelo.Clear();
            cbaño.SelectedIndex = -1;
            rdbtnsuv.Checked = false;
            rdbtnpickup.Checked = false;
            rdbtnsedan.Checked = false;
            cocheEditando = null; // importante resetear esto
        }

        // eventos vacios que el designer genero automaticamente
        private void txtplaca_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtmarca_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbaño_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void rdbtnsuv_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdbtnpickup_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdbtnsedan_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
        }

        private void txtaño_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbaño_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void gpotipo_Enter(object sender, EventArgs e)
        {
        }
    }
}
