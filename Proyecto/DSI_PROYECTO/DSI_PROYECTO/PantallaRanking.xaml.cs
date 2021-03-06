using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
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
    public sealed partial class PantallaRanking : Page
    {
        public ObservableCollection<ViewModelRanking> ListaRanking { get; } = new ObservableCollection<ViewModelRanking>();
        public PantallaRanking()
        {
            this.InitializeComponent();
        }

        // Botón de navegación hacia atrás.
        private void Atras_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PantallaPrincipal));
        }

        // Botones de navegación en la parte superior.
        private void Tienda_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Tienda));
        }

        private void Galeria_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GaleriaDeMazos));
        }

        private void PantallaPrincipal_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PantallaPrincipal));
        }

        private void Opciones_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OpcionesMenu));
        }

        // Control de teclado estando en la pantalla.
        private void Grid_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            // Si se pulsa el botón de Menú o Escape, se cierra la aplicación (no se tiene en cuenta la tecla B).
            if (e.OriginalKey != VirtualKey.GamepadB)
                if (e.Key == VirtualKey.GamepadMenu || e.Key == VirtualKey.Escape) {
                    CoreApplication.Exit();
                }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Cosntruye las listas de ModelView a partir de la lista Modelo 
            if (ListaRanking != null)
                foreach (Ranking rango in ModelRanking.getAllRankings())
                {
                    ViewModelRanking VMitem = new ViewModelRanking(rango);
                    ListaRanking.Add(VMitem);
                }
            base.OnNavigatedTo(e);
        }

        private void B4_Unchecked(object sender, RoutedEventArgs e)
        {
            B4.IsChecked = true;
        }
    }
}
