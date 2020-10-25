//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
        /// <summary>
        /// Se cumple con Expert ya que el paso que conoce los datos a imprimir genera el texto a
        /// imprimir. Tambien se logra mantener la encapsulacion.
        /// </summary>
        /// <returns>texto que se quiere agregar a la impresion</returns>
        public string StepText()
        {
            string result="";
            result=$"{this.Quantity} de '{this.Input.Description}' " +
                    $"usando '{this.Equipment.Description}' durante {this.Time}";
            return result;
        }
    }
}