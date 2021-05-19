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
    public sealed partial class GaleriaDeMazos : Page
    {
        public ObservableCollection<VMMazos_Grid> GridMazos { get; } = new ObservableCollection<VMMazos_Grid>();

        public VMMazos_Grid mazoActual;

        public GaleriaDeMazos()
        {
            this.InitializeComponent();
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

        private void Mazos_Normal(object sender, RoutedEventArgs e)
        {
            GridMazos.Clear();
            // Cosntruye las listas de ModelView a partir de la lista Modelo 
            if (GridMazos != null && (bool)BN.IsChecked)
            {
                foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                {
                    if (mazos.Imagen == "Assets\\mazo1.png")
                    {
                        VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                        GridMazos.Add(VMitem);
                    }
                }
                BR.IsChecked = false;
                BS.IsChecked = false;
                BO.IsChecked = false;
            }
            else if (GridMazos != null)
            {
                if (GridMazos != null)
                    foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                    {
                        VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                        GridMazos.Add(VMitem);
                    }
            }
        }

        private void Mazos_Ranked(object sender, RoutedEventArgs e)
        {
            GridMazos.Clear();
            // Cosntruye las listas de ModelView a partir de la lista Modelo 
            if (GridMazos != null && (bool)BR.IsChecked)
            {
                foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                {
                    if (mazos.Imagen == "Assets\\mazo2.png")
                    {
                        VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                        GridMazos.Add(VMitem);
                    }
                }
                BN.IsChecked = false;
                BS.IsChecked = false;
                BO.IsChecked = false;
            }
            else if (GridMazos != null)
            {
                if (GridMazos != null)
                    foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                    {
                        VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                        GridMazos.Add(VMitem);
                    }
            }
        }

        private void Mazos_SpellBreak(object sender, RoutedEventArgs e)
        {
            GridMazos.Clear();
            // Cosntruye las listas de ModelView a partir de la lista Modelo 
            if (GridMazos != null && (bool)BS.IsChecked)
            {
                foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                {
                    if (mazos.Imagen == "Assets\\mazo4.png")
                    {
                        VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                        GridMazos.Add(VMitem);
                    }
                }
                BR.IsChecked = false;
                BN.IsChecked = false;
                BO.IsChecked = false;
            }
            else if (GridMazos != null)
            {
                if (GridMazos != null)
                    foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                    {
                        VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                        GridMazos.Add(VMitem);
                    }
            }
        }

        private void Mazos_Order(object sender, RoutedEventArgs e)
        {
            GridMazos.Clear();
            // Cosntruye las listas de ModelView a partir de la lista Modelo 
            if (GridMazos != null && (bool)BO.IsChecked)
            {
                foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                {
                    if (mazos.Imagen == "Assets\\mazo3.png")
                    {
                        VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                        GridMazos.Add(VMitem);
                    }
                }
                BR.IsChecked = false;
                BS.IsChecked = false;
                BN.IsChecked = false;
            }
            else if (GridMazos != null)
            {
                if (GridMazos != null)
                    foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                    {
                        VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                        GridMazos.Add(VMitem);
                    }
            }
        }

        private void Go_Coleccion(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ColeccionCartas));
        }

        private void Go_Coleccion_Edit(object sender, RoutedEventArgs e)
        {
            if(mazoActual != null)
            this.Frame.Navigate(typeof(ColeccionCartas), mazoActual);
        }

        private void Go_Tienda(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Tienda));
        }

        private void Go_Pantalla_Principal(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PantallaPrincipal));
        }

        private void Go_Ranking(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PantallaRanking));
        }

        private void Go_Opciones(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OpcionesMenu));
        }

        private void mazosGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
            VMMazos_Grid mazo = e.ClickedItem as VMMazos_Grid;
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + mazo.Imagen;

            MazoPrincipal.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            mazoActual = mazo;
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
                this.Frame.GoBack();
        }
    }
}
