//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
        /// <summary>
        /// Se cumple con Expert ya que la receta que conoce los datos a imprimir genera el texto a
        /// imprimir. Tambien se logra mantener la encapsulacion.
        /// </summary>
        /// <returns>texto a imprimir</returns>
        public string StringToPrint()
        {
            string result="";
            result+= $"Receta de {this.FinalProduct.Description}: \n";
            foreach (Step step in this.steps)
            {
                result+= step.StepText();
                result+="\n";
            }
            return result;
        }
    }
}