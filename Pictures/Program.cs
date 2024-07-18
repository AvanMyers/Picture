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
            int imagesNumber = 52;
            int rowImages = 3;
            int filledRows;
            int imagenesRest;

            filledRows = imagesNumber / rowImages;
            imagenesRest = imagesNumber % rowImages;

            Console.WriteLine($"Заполненных рядов {filledRows}, свободных карточек осталось {imagenesRest}");
            Console.ReadKey();
        }
    }
}
