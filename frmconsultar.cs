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
    // form para consultar coches, solo ver la info sin modificar nada
    public partial class frmconsultar : Form
    {
        // constructor basico como siempre
        public frmconsultar()
        {
            InitializeComponent();
        }

        private void frmconsultar_Load(object sender, EventArgs e)
        {
            // vaciooo
        }

        // aqui buscas el coche por placa y lo muestras
        // nada mas pa verlo, no pa editarlo
        private void btnconsultar_Click(object sender, EventArgs e)
        {
            string placaBuscada = txtplacaconsultar.Text.Trim().ToUpper(); // mayusculas siempre

            // validacion rapida, no busques sin placa
            if (string.IsNullOrWhiteSpace(placaBuscada))
            {
                MessageBox.Show("Por favor, ingrese una placa.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // salimos si esta vacio
            }

            try
            {
                // buscamos en la base de datos
                Coche coche = CocheDAO.ConsultarCochePorPlaca(placaBuscada);

                if (coche != null)
                {
                    // si lo encontro mostramos todos los datos en los textboxes
                    txtmarca.Text = coche.Marca;
                    txtmodelo.Text = coche.Modelo;
                    txtaño.Text = coche.Anio.ToString();
                    txttipo.Text = coche.Tipo;

                    // mensaje de exito 
                    MessageBox.Show("Vehículo encontrado.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // no existe ese coche
                    MessageBox.Show("Placa no encontrada en la base de datos.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); // limpiamos todo por si tenia algo de antes
                }
            }
            catch (Exception ex)
            {
                // si truena mostramos el error
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // boton para regresar al menu principal
        private void btnconsultarregresar_Click(object sender, EventArgs e)
        {
            this.Close(); // chao
        }

        // metodo auxiliar pa limpiar todos los campos
        private void LimpiarCampos()
        {
            txtmarca.Clear();
            txtmodelo.Clear();
            txtaño.Clear();
            txttipo.Clear();
        }

        // mas eventos vacios que no sirven pa nada
        private void txtplacaconsultar_TextChanged(object sender, EventArgs e)
        {
            // nada
        }
        private void txtmarca_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtaño_TextChanged(object sender, EventArgs e)
        {
        }

        private void txttipo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
