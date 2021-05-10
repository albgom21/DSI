using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace DSI_PROYECTO
{
    public class VMCartas : Cartas
    {      
        public VMCartas(Cartas cart)
        {
            cantidad = cart.cantidad;
            Nombre = cart.Nombre;     
        }
    }

    public class VMCartas_Grid : Cartas_Grid
    {
        public Image Img;
        public VMCartas_Grid(Cartas_Grid cart)
        {
            Name = cart.Name;
            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + cart.Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));                     
        }
    }

    public class VMMazos_Grid : Mazos_Grid
    {
        public Image Img;
        public VMMazos_Grid(Mazos_Grid cart)
        {
            Name = cart.Name;
            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + cart.Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));            
        }
    }
}
