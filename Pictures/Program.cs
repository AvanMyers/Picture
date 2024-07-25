using System;


namespace Pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int imagesCount = 52;
            int countLineImage = 3;
            int filledRows;
            int imagenesRest;

            filledRows = imagesCount / countLineImage;
            imagenesRest = imagesCount % countLineImage;

            Console.WriteLine($"Заполненных рядов {filledRows}, свободных карточек осталось {imagenesRest}");
            Console.ReadKey();
        }
    }
}
