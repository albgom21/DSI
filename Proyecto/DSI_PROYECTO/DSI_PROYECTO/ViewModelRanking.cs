using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace DSI_PROYECTO
{
    public class ViewModelRanking : Ranking
    {
        public Image Img1;
        public Image Img2;
        public ContentControl CCImg1;
        public ContentControl CCImg2;

        public ViewModelRanking(Ranking rango){
            Id = rango.Id;
            Nivel = rango.Nivel;
            Nombre = rango.Nombre;
            Rango = rango.Rango;
            Imagen1 = "Assets\\eye.png";
            Imagen2 = "Assets\\mazo.png";
            Img1 = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + Imagen1;
            Img1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            Img1.Width = 50;
            Img1.Height = 50;
            Img2 = new Image();
            string s1 = System.IO.Directory.GetCurrentDirectory() + "\\" + Imagen2;
            Img2.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            Img2.Width = 50;
            Img2.Height = 50;
        }
    }
}
