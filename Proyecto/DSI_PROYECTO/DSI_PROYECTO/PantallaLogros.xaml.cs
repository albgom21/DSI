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
    public sealed partial class PantallaLogros : Page
    {
        public List<VirtualKey> keys = new List<VirtualKey>();
        public ObservableCollection<VM_Logro> ListaLogros { get; } = new ObservableCollection<VM_Logro>();
        public PantallaLogros()
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

        private void Ranking_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PantallaRanking));
        }

        private void Opciones_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OpcionesMenu));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Cosntruye las listas de ModelView a partir de la lista Modelo 
            if (ListaLogros != null)
                foreach (Logro logro in ModelLogro.getAllLogros())
                {
                    VM_Logro VMitem = new VM_Logro(logro);
                    ListaLogros.Add(VMitem);
                }
            base.OnNavigatedTo(e);
        }
        // Control de teclado estando en la pantalla.
        private void Grid_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            // Si se pulsa el botón de Menú o Escape, se cierra la aplicación (no se tiene en cuenta la tecla B).
            if (e.OriginalKey != VirtualKey.GamepadB)
                if (e.Key == VirtualKey.GamepadMenu || e.Key == VirtualKey.Escape)
                {
                    CoreApplication.Exit();
                }

            // Sistema de aceleradores.
            keys.Add(e.Key);
            int t = 0, g = 0, r = 0, o = 0;
            for (int i = 0; i < keys.Count(); i++)
            {
                if (keys[i] == VirtualKey.Control || keys[i] == VirtualKey.GamepadLeftTrigger)
                    t++; g++; r++; o++;

                if (keys[i] == VirtualKey.Number1 || keys[i] == VirtualKey.GamepadA) t++;
                if (keys[i] == VirtualKey.Number2 || keys[i] == VirtualKey.GamepadB) g++;
                if (keys[i] == VirtualKey.Number4 || keys[i] == VirtualKey.GamepadX) r++;
                if (keys[i] == VirtualKey.Number5 || keys[i] == VirtualKey.GamepadY) o++;
            }
            if (t >= 2) this.Frame.Navigate(typeof(Tienda));
            else if (g >= 2) this.Frame.Navigate(typeof(GaleriaDeMazos));
            else if (r >= 2) this.Frame.Navigate(typeof(PantallaRanking));
            else if (o >= 2) this.Frame.Navigate(typeof(OpcionesMenu));
            // Con la B va directamente a la pantalla principal.
        }
    }
}
