using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int imagesCount = 52;
            int rowImagesLine = 3;
            int filledRows;
            int imagenesRest;

            filledRows = imagesCount / rowImagesLine;
            imagenesRest = imagesCount % rowImagesLine;

            Console.WriteLine($"Заполненных рядов {filledRows}, свободных карточек осталось {imagenesRest}");
            Console.ReadKey();
        }
    }
}
