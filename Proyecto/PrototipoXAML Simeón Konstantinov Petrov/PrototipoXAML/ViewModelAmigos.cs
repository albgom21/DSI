using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace PrototipoXAML
{
    public class ViewModelAmigos : Amigo
    {
        public Image Img;
        public ContentControl CCImg;

        public ViewModelAmigos(Amigo amigo)
        {
            Id = amigo.Id;
            Nombre = amigo.Nombre;
            Imagen = amigo.Imagen;

            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            Img.Width = 10;
            Img.Height = 10;
        }
    }
}
