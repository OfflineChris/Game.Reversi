using System.Windows.Media;

namespace Reversi
{
    static class MieszanieKolorów
    {
        public static Color Lerp(this Color kolor, Color innyKolor, double waga)
        {
            byte r = (byte)(waga * kolor.R + (1 - waga) * innyKolor.R);
            byte g = (byte)(waga * kolor.G + (1 - waga) * innyKolor.G);
            byte b = (byte)(waga * kolor.B + (1 - waga) * innyKolor.B);
            return Color.FromRgb(r, g, b);  
        }
        public static SolidColorBrush Lerp(this SolidColorBrush pędzel, SolidColorBrush innyPędziel, double waga)
        {
            return new SolidColorBrush(Lerp(innyPędziel.Color, innyPędziel.Color, waga));
        }
    }
}
