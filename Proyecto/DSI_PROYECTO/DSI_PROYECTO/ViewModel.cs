using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace DSI_PROYECTO
{
    public class VM_Logro : Logro
    {
        public Image Img;
        public Image Img2;
        public ContentControl CCImg;
        public ContentControl CCImg2;
        public VM_Logro(Logro dron)
        {
            Id = dron.Id;
            Nombre = dron.Nombre;
            Imagen = dron.Imagen;
            Descripcion = dron.Descripcion;
            Recompensa = dron.Recompensa;
            Coin = "Assets\\coins.png";
            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + dron.Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            Img.Width = 50;
            Img.Height = 50;
            Img2 = new Image();
            string s2 = System.IO.Directory.GetCurrentDirectory() + "\\" + Coin;
            Img2.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            Img2.Width = 50;
            Img2.Height = 50;
            CCImg = new ContentControl();
            CCImg.Content = Img;
            CCImg2 = new ContentControl();
            CCImg2.Content = Img2;
        }
    };

    public class VMCartas : Cartas
    {
        public VMCartas() { }
                
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
            Tipo = cart.Tipo;
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
            Imagen = cart.Imagen;
            Cartas = cart.Cartas;
            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + cart.Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));            
        }
    }
}
