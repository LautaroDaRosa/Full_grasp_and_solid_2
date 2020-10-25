using System;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Esta clase cumple con SRP debido a que solo tiene una razon de cambio, Print Recipe.
    /// </summary>
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.StringToPrint());
        }
    }
}