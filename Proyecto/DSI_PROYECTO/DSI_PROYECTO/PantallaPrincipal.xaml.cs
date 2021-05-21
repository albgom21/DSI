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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace DSI_PROYECTO
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class PantallaPrincipal : Page
    {
        public bool found = false;
        public int i = 0;
        public List<VirtualKey> keys = new List<VirtualKey>();
        public ObservableCollection<ViewModelAmigos> ListaAmigos { get; } = new ObservableCollection<ViewModelAmigos>();
        public PantallaPrincipal()
        {
            this.InitializeComponent();
        }

        // Botones de navegación en la parte superior.
        private void Tienda_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Tienda));
        }

        private void Galeria_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(GaleriaDeMazos));
        }

        private void Ranking_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(PantallaRanking));
        }

        private void Opciones_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OpcionesMenu));
        }

        // Botón de navegación para los logros.
        private void Logros_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(PantallaLogros));
        }

        // Botón de navegación para jugar.
        private void Jugar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ModosDeJuego));
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
            if (ListaAmigos != null)
                foreach (Amigo amigo in ModelA.getAllAmigos())
                {
                    ViewModelAmigos VMitem = new ViewModelAmigos(amigo);
                    ListaAmigos.Add(VMitem);
                }
            base.OnNavigatedTo(e);
        }

        // Método que permite buscar amigos.
        private void AmigosTexto_TextChanged(object sender, TextChangedEventArgs e)
        {
            // El total de amigos.
            int k = ListaAmigos.Count();

            // Comprueba si ya se había buscado un amigo al borrar la lista anteriormente.
            if (i != k && found == true) {
                // En caso afirmativo, vuelve a rellenar la lista con todos los amigos.
                ListaAmigos.Clear();
                foreach (Amigo amigo in ModelA.getAllAmigos()) {
                    ViewModelAmigos VMitem = new ViewModelAmigos(amigo);
                    ListaAmigos.Add(VMitem);
                }
                found = false;
            }

            // Busca en la lista un amigo con el nombre introducido.
            for (int j = 0; j < ListaAmigos.Count(); j++) {
                if (AmigosTexto.Text == ListaAmigos[j].Nombre) {
                    ViewModelAmigos Amigo = ListaAmigos[j];
                    ListaAmigos.Clear();
                    ListaAmigos.Add(Amigo);
                    found = true;
                }
                i++;
            }
        }

        private void B3_Unchecked(object sender, RoutedEventArgs e)
        {           
           B3.IsChecked = true;            
        }
    }
}
