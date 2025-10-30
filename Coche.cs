using System;

namespace Proyecto_Unidad_1_Programacion_Visual
{
    public class Coche
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Tipo { get; set; }

        public Coche()
        {
            Placa = string.Empty;
            Marca = string.Empty;
            Modelo = string.Empty;
            Tipo = string.Empty;
        }
    }
}
