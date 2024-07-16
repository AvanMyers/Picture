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
            int numberOfImages = 52;
            int imagesInRow = 3;
            int filledRows;
            int restOfTheImagenes;

            filledRows = numberOfImages / imagesInRow;
            restOfTheImagenes = numberOfImages % imagesInRow;

            Console.WriteLine($"Заполненных рядов {filledRows}, свободных карточек осталось {restOfTheImagenes}");
            Console.ReadKey();
        }
    }
}
