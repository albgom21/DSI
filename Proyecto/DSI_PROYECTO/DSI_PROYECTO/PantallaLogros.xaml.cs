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
        public int progressBar = 0;
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
                    if (logro.Imagen == "Assets\\star.png") progressBar += 10;
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
        }

        // Método para bloquear/desbloquear logros.
        private void ImageGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            VM_Logro Item = e.ClickedItem as VM_Logro;
            int id = Item.Id;
            int i = 0;
            ListaLogros.Clear();
            foreach (Logro logro in ModelLogro.getAllLogros()) {
                if (i == id) {
                    if (logro.Imagen == "Assets\\lock.png") {
                        logro.Imagen = "Assets\\star.png";
                        pbar.Value += 10;
                    }
                    else {
                        logro.Imagen = "Assets\\lock.png";
                        pbar.Value -= 10;
                    }
                }
                VM_Logro VMitem = new VM_Logro(logro);
                ListaLogros.Add(VMitem);
                i++;
            }
        }
    }
}
