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
    // form para eliminar coches de la base de datos
    public partial class frmbaja : Form
    {
        // constructor normal, nada especial
        public frmbaja()
        {
            InitializeComponent();
        }
        private void txtbajaplaca_TextChanged(object sender, EventArgs e)
        {
        }

        // el boton importante, aqui se elimina el coche
        // primero verifica que exista y luego te pide confirmacion por si te arrepientes
        private void btnbajaeliminar_Click(object sender, EventArgs e)
        {
            string placaEliminar = txtbajaplaca.Text.Trim().ToUpper(); // mayusculas siempre

            // validacion basica, no dejes el campo vacio
            if (string.IsNullOrWhiteSpace(placaEliminar))
            {
                MessageBox.Show("Por favor, ingrese una placa.", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // nos vamos si esta vacio
            }

            try
            {
                // primero buscamos el coche para ver si existe
                Coche coche = CocheDAO.ConsultarCochePorPlaca(placaEliminar);

                if (coche == null)
                {
                    // no existe ese coche 
                    MessageBox.Show("Placa no encontrada en la base de datos.", "Información", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // salimos porque no hay nada que eliminar
                }

                // si existe le mostramos los datos y pedimos confirmacion
                // por si se equivoco y no quiere eliminarlo
                var confirm = MessageBox.Show(
                    $"¿Está seguro que desea eliminar este vehículo?\n\n" +
                    $"Placa: {coche.Placa}\n" +
                    $"Marca: {coche.Marca}\n" +
                    $"Modelo: {coche.Modelo}\n" +
                    $"Año: {coche.Anio}\n" +
                    $"Tipo: {coche.Tipo}",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning); // icono de warning para que se asuste un poco

                // si le dio a SI entonces si lo eliminamos
                if (confirm == DialogResult.Yes)
                {
                    bool resultado = CocheDAO.EliminarCoche(placaEliminar);

                    if (resultado)
                    {
                        // todo bien, eliminado exitosamente
                        MessageBox.Show("Vehículo eliminado correctamente de la base de datos.", "Éxito", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtbajaplaca.Clear(); // limpiamos el textbox
                        txtbajaplaca.Focus(); // lo dejamos listo para eliminar otro 
                    }
                    else
                    {
                        // algo salio mal, no se pudo eliminar
                        MessageBox.Show("No se pudo eliminar el vehículo.", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // si le dio a NO pues no pasa nada y se quedan los datos tal cual 
            }
            catch (Exception ex)
            {
                // si truena algo mostramos el error
                MessageBox.Show(ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmbaja_Load(object sender, EventArgs e)
        {
        }
    }
}
