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
                rbutton.IsChecked = false;
                sbutton.IsChecked = false;
                obutton.IsChecked = false;

                descripcion.Text = "NORMAL: máximo de 20 cartas en el mazo, pudiendo tener 3 copias de la misma carta.";
            }
        }

        private void rbutton_Checked(object sender, RoutedEventArgs e)
        {
            nbutton.IsChecked = false;           
            sbutton.IsChecked = false;
            obutton.IsChecked = false;
            descripcion.Text = "RANKED: partida igualadas respecto a tu rango con máximo de 20 cartas en el mazo, pudiendo tener 3 copias de la misma carta.";
        }

        private void sbutton_Checked(object sender, RoutedEventArgs e)
        {
            nbutton.IsChecked = false;
            rbutton.IsChecked = false;
            obutton.IsChecked = false;
            descripcion.Text = "SPELLBREAK: mazos de 20 cartas de hechizos, al jugar un hechizo se invoca una unidad aleatoria del mismo coste del hechizo y se activa este";
        }

        private void obutton_Checked(object sender, RoutedEventArgs e)
        {
            nbutton.IsChecked = false;
            sbutton.IsChecked = false;
            rbutton.IsChecked = false;
            descripcion.Text = "ORDER: el mazo se construye con 20 tipos de cartas diferentes";
        }

        private void B5_Checked(object sender, RoutedEventArgs e)
        {
            B2.IsChecked = false;
            B3.IsChecked = false;
            B4.IsChecked = false;
            B1.IsChecked = false;
        }

        private void B4_Checked(object sender, RoutedEventArgs e)
        {
            B2.IsChecked = false;
            B3.IsChecked = false;
            B1.IsChecked = false;
            B5.IsChecked = false;
        }

        private void B3_Checked(object sender, RoutedEventArgs e)
        {
            B2.IsChecked = false;
            B1.IsChecked = false;
            B4.IsChecked = false;
            B5.IsChecked = false;
        }

        private void B2_Checked(object sender, RoutedEventArgs e)
        {
            B1.IsChecked = false;
            B3.IsChecked = false;
            B4.IsChecked = false;
            B5.IsChecked = false;
        }

        private void B1_Checked(object sender, RoutedEventArgs e)
        {
            B2.IsChecked = false;
            B3.IsChecked = false;
            B4.IsChecked = false;
            B5.IsChecked = false;
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
 
            MazoSel.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            
        }
    }
}
