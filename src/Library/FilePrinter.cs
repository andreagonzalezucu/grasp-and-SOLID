using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(ITextGenerator textGenerator)
        {
            File.WriteAllText("Recipe.txt", textGenerator.GetTextToPrint());
        }
    }
}