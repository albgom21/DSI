using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_PROYECTO
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ModosDeJuego : Page
    {
        public ObservableCollection<VMMazos_Grid> GridMazos { get; } = new ObservableCollection<VMMazos_Grid>();

        public ModosDeJuego()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled; //Required si se quieren ignorar los límites de CacheSize
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Cosntruye las listas de ModelView a partir de la lista Modelo 
            if (GridMazos != null)
                foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                {
                    VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                    GridMazos.Add(VMitem);
                }
           
            base.OnNavigatedTo(e);
        }

        private void nbutton_Checked(object sender, RoutedEventArgs e)
        {
            if (rbutton != null )
            {
                GridMazos.Clear();                
                if (GridMazos != null)
                {
                    foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                    {
                        if (mazos.Imagen == "Assets\\mazo1.png")
                        {
                            VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                            GridMazos.Add(VMitem);
                        }
                    }
                    rbutton.IsChecked = false;
                    sbutton.IsChecked = false;
                    obutton.IsChecked = false;
                }       
                descripcion.Text = "NORMAL: mazos de 20 cartas máximo, pudiendo tener 3 copias de la misma carta.";
            }
        }

        private void rbutton_Checked(object sender, RoutedEventArgs e)
        {
            GridMazos.Clear();           
            if (GridMazos != null)
            {
                foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                {
                    if (mazos.Imagen == "Assets\\mazo2.png")
                    {
                        VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                        GridMazos.Add(VMitem);
                    }
                }
                sbutton.IsChecked = false;
                nbutton.IsChecked = false;
                obutton.IsChecked = false;
            }
         
            descripcion.Text = "RANKED: partida igualadas respecto a tu rango con mazos de 20 cartas máximo, pudiendo tener 3 copias de la misma carta.";
        }

        private void sbutton_Checked(object sender, RoutedEventArgs e)
        {
            GridMazos.Clear();
            if (GridMazos != null)
            {
                foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                {
                    if (mazos.Imagen == "Assets\\mazo4.png")
                    {
                        VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                        GridMazos.Add(VMitem);
                    }
                }
                rbutton.IsChecked = false;
                nbutton.IsChecked = false;
                obutton.IsChecked = false;
            }         
            descripcion.Text = "SPELLBREAK: mazos de 20 cartas de hechizos, al jugar un hechizo también se invoca una unidad aleatoria,";
        }

        private void obutton_Checked(object sender, RoutedEventArgs e)
        {
            GridMazos.Clear();
            if (GridMazos != null)
            {
                foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                {
                    if (mazos.Imagen == "Assets\\mazo3.png")
                    {
                        VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                        GridMazos.Add(VMitem);
                    }
                }
                sbutton.IsChecked = false;
                nbutton.IsChecked = false;
                rbutton.IsChecked = false;
            }
       
            descripcion.Text = "ORDER: el mazo se construye con 20 tipos de cartas diferentes.";
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
                this.Frame.GoBack();
        }

        private void mazosGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            VMMazos_Grid mazo = e.ClickedItem as VMMazos_Grid;
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + mazo.Imagen;
            if (mazo.Imagen == "mazo1.png")
                nbutton.IsChecked = true;
 
            MazoSel.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            mazoName.Text = mazo.Name;            
        }

        private void restartMazos(object sender, RoutedEventArgs e)
        {
            if (GridMazos != null && !(bool)nbutton.IsChecked && !(bool)sbutton.IsChecked && !(bool)obutton.IsChecked && !(bool)rbutton.IsChecked)
            {
                GridMazos.Clear();
                foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                {
                    VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                    GridMazos.Add(VMitem);
                }
                descripcion.Text = "ELIGE UN MODO DE JUEGO";
                mazoName.Text = "";
                string s = System.IO.Directory.GetCurrentDirectory() + "\\" + "Assets/Mazo0.png";
                MazoSel.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));                
            }
        }
        
        private void Tienda(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Tienda));
            B1.IsChecked = false;
        }
        private void Galeria_Mazos(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GaleriaDeMazos));
            B2.IsChecked = false;
        }
        private void Ranking(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PantallaRanking));
            B4.IsChecked = false;
        }

        private void Opciones(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OpcionesMenu));
            B5.IsChecked = false;
        }

        private void Jugar_Click(object sender, RoutedEventArgs e)
        {
            if(mazoName.Text != "")
               this.Frame.Navigate(typeof(InGame), a.SelectedItem);            
        }

        private void B3_Unchecked(object sender, RoutedEventArgs e)
        {
            B3.IsChecked = true;
        }
    }
}
